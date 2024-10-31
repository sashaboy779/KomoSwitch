using System;
using System.IO;
using System.IO.Pipes;
using System.Threading;
using KomoSwitch.CommandPrompt;
using KomoSwitch.Models.EventArgs;
using KomoSwitch.Models.Notifications;
using Newtonsoft.Json;
using Serilog;

namespace KomoSwitch
{
    public class EventListener
    {
        public event EventHandler ConnectionEstablished;
        public event EventHandler ConnectionLost;
        public event EventHandler ConnectionFailed;
        public event EventHandler<WorkspaceFocusedEventArgs> WorkspaceFocused;
        
        private readonly EventWaitHandle _shutdownEvent = new ManualResetEvent(false);
        private CancellationTokenSource _cancellationTokenSource;

        private const string PipeName = "KomoSwitchPipe";
        private const int SubscribeCommandAttempt = 20;
        private const int WaitBetweenSubscribePipeCommand = 3;
        
        public void Start()
        {
            new Thread(StartPipeLoop).Start();
            new Thread(SubscribeKomorebiToPipe).Start();
        }

        private void StartPipeLoop()
        {
            try
            {
                StartPipeLoopInternal();
            }
            catch (Exception e)
            {
                Log.Fatal(e, "An unexpected error occured");
            }
        }
        
        private void SubscribeKomorebiToPipe()
        {
            try
            {
                SubscribeKomorebiToPipeInternal();
            }
            catch (Exception e)
            {
                Log.Fatal(e, "An unexpected error occured");
            }
        }

        private void StartPipeLoopInternal()
        {
            var isShutdownRequested = false;
            
            while (!isShutdownRequested)
            {
                var stream = new NamedPipeServerStream(PipeName, PipeDirection.In, -1, PipeTransmissionMode.Message, PipeOptions.Asynchronous);
                try
                {
                    var result = stream.BeginWaitForConnection(HandleConnection, stream);
                    var waitResult = WaitHandle.WaitAny(new[] { result.AsyncWaitHandle, _shutdownEvent });
                    _cancellationTokenSource.Cancel();

                    switch (waitResult)
                    {
                        case 1:
                            Log.Information("Shutdown requested");
                            isShutdownRequested = true;
                            stream.Close();
                            stream.Dispose();
                            break;
                        case 0:
                            Log.Information("Komorebi connected");
                            ConnectionEstablished?.Invoke(this, EventArgs.Empty);
                            break;
                    }
                }
                catch (IOException)
                {
                    stream.Close();
                    stream.Dispose();
                }
            }
        }

        private void SubscribeKomorebiToPipeInternal()
        {
            _cancellationTokenSource = new CancellationTokenSource();

            try
            {
                Log.Information("Running subscribe pipe command");
                
                var attemptsLeft = SubscribeCommandAttempt;
                while (attemptsLeft != 0)
                {
                    _cancellationTokenSource.Token.ThrowIfCancellationRequested();
                    
                    var result = CommandPromptWrapper.SubscribePipe(PipeName);
                    if (result.IsSuccess)
                    {
                        Log.Information("Successfully subscribed");
                        return;
                    }
                    
                    Log.Information("Command was ran. {Attempt} attempts left. Error: {Error}", attemptsLeft, result.Error);

                    Thread.Sleep(WaitBetweenSubscribePipeCommand * 1_000);
                    attemptsLeft--;
                }
                    
                Log.Error("Ran out of attempts");
                Stop();
                
                ConnectionFailed?.Invoke(this, EventArgs.Empty);
            }
            catch (OperationCanceledException)
            {
                Log.Information("Gracefully stopped running subscribe pipe command");
            }
            catch (Exception e)
            {
                Log.Error(e, "Exception occured: {Message}", e.Message);
            }
        }

        private void HandleConnection(IAsyncResult result)
        {
            var stream = (NamedPipeServerStream)result.AsyncState;
            try
            {
                using (stream)
                using (var reader = new StreamReader(stream))
                {
                    stream.EndWaitForConnection(result);
                    while (stream.IsConnected)
                    {
                        var rawText = reader.ReadLine();
                            
                        if (string.IsNullOrEmpty(rawText))
                            break;

                        ProcessNotification(rawText);
                    }
                }

                Log.Warning("Komorebi disconnected. Trying to reconnect");
                ConnectionLost?.Invoke(this, EventArgs.Empty);
                
                new Thread(SubscribeKomorebiToPipe).Start();
            }
            catch (ObjectDisposedException e)
            {
                Log.Error($"Pipe was disposed, {e.Message}");
            }
        }

        private void ProcessNotification(string rawText)
        {
            var notification = JsonConvert.DeserializeObject<Notification>(rawText);
            Log.Information("Received Event: {Type}", notification.Event.Type);

            if (notification.Event.Type == "FocusWorkspaceNumber")
            {
                var workspaceIndex = Convert.ToInt32(notification.Event.Content);
                WorkspaceFocused?.Invoke(this, new WorkspaceFocusedEventArgs(workspaceIndex));
            }
        }

        public void Stop() 
        {
            _shutdownEvent.Set();
            
            Log.Information("Running unsubscribe pipe command");
            CommandPromptWrapper.UnsubscribePipe(PipeName);
        }
    }
}