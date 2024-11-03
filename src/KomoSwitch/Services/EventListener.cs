using System;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Threading;
using KomoSwitch.CommandPrompt;
using KomoSwitch.Models.EventArgs;
using KomoSwitch.Models.Notifications;
using Microsoft.Win32;
using Newtonsoft.Json;
using Serilog;

namespace KomoSwitch.Services
{
    public class EventListener
    {
        public event EventHandler<ConnectionEstablishedEventArgs> ConnectionEstablished;
        public event EventHandler ConnectionLost;
        public event EventHandler ConnectionFailed;
        public event EventHandler<WorkspaceFocusedEventArgs> WorkspaceFocused;
        
        private readonly EventWaitHandle _shutdownPipeLoopEvent = new ManualResetEvent(false);
        private CancellationTokenSource _subscribeCancellation;

        private const string PipeName = "KomoSwitchPipe";
        private const int SubscribeCommandAttempt = 20;
        private const int WaitBetweenSubscribePipeCommand = 3;
        private const int WaitBeforeReconnectKomorebi = 3;
        
        private bool _isWindowsShuttingDown;
        private bool _isApplicationShuttingDown;

        public void Start()
        {
            new Thread(StartPipeLoop).Start();
            new Thread(SubscribeKomorebiToPipe).Start();
            
            SystemEvents.SessionEnding += OnSessionEnding;
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
                    var waitResult = WaitHandle.WaitAny(new[] { result.AsyncWaitHandle, _shutdownPipeLoopEvent });
                    _subscribeCancellation.Cancel();

                    switch (waitResult)
                    {
                        case 1:
                            Log.Information("Pipe shutdown requested");
                            isShutdownRequested = true;
                            stream.Close();
                            stream.Dispose();
                            break;
                        case 0:
                            Log.Information("Komorebi connected to pipe");
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
            _subscribeCancellation = new CancellationTokenSource();

            try
            {
                var attemptsLeft = SubscribeCommandAttempt;
                while (attemptsLeft != 0)
                {
                    Log.Information("Running subscribe-pipe command");

                    if (_subscribeCancellation.Token.IsCancellationRequested)
                    {
                        Log.Information("Cancellation was requested");
                        return;
                    }
                    
                    var result = CommandPromptWrapper.SubscribePipe(PipeName);
                    if (result.IsSuccess)
                    {
                        Log.Information("Komorebi Successfully subscribed to pipe");
                        return;
                    }
                    
                    Log.Information("{Attempt} attempts left. Error: {Error}", --attemptsLeft, result.Error);
                    Thread.Sleep(TimeSpan.FromSeconds(WaitBetweenSubscribePipeCommand));
                }
                    
                Log.Error("Ran out of attempts");
                Stop();
                
                ConnectionFailed?.Invoke(this, EventArgs.Empty);
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

                ConnectionLost?.Invoke(this, EventArgs.Empty);
                TryReconnect();
            }
            catch (ObjectDisposedException e)
            {
                Log.Error("Pipe was disposed. {Message}", e.Message);
            }
        }

        private void TryReconnect()
        {
            Log.Warning("Komorebi disconnected. Waiting for {WaitSeconds} seconds", WaitBeforeReconnectKomorebi);
            Thread.Sleep(TimeSpan.FromSeconds(WaitBeforeReconnectKomorebi));
                
            if (_isWindowsShuttingDown)
            {
                Log.Information("No need to reconnect. Windows is shutting down");
                return;
            }
                 
            if (_isApplicationShuttingDown)
            {
                Log.Information("No need to reconnect. Application is shutting down");
                return;
            }
                
            Log.Information("Reconnect initiated");
            new Thread(SubscribeKomorebiToPipe).Start();
        }

        private void ProcessNotification(string rawText)
        {
            var notification = JsonConvert.DeserializeObject<Notification>(rawText);
            Log.Information("Received: {Type}", notification.Event.Type);

            if (notification.Event.Type == "FocusWorkspaceNumber")
            {
                var workspaceIndex = Convert.ToInt32(notification.Event.Content);
                WorkspaceFocused?.Invoke(this, new WorkspaceFocusedEventArgs(workspaceIndex));
            }
            else if (notification.Event.Type == "AddSubscriberPipe")
            {
                var firstMonitor = notification.State.Monitors.Elements.FirstOrDefault();
                if (firstMonitor == null)
                {
                    Log.Error("No Monitor received from komorebi");
                    return;
                }
                
                var eventArgs = new ConnectionEstablishedEventArgs(firstMonitor);
                ConnectionEstablished?.Invoke(this, eventArgs);
            }
        }

        public void Stop()
        {
            _isApplicationShuttingDown = true;
            _shutdownPipeLoopEvent.Set();
            
            Log.Information("Running unsubscribe pipe command");
            CommandPromptWrapper.UnsubscribePipe(PipeName);
            
            SystemEvents.SessionEnding -= OnSessionEnding;
        }

        private void OnSessionEnding(object sender, SessionEndingEventArgs e)
        {
            Log.Information("Received session ending event: {Reason}", e.Reason);
            if (e.Reason != SessionEndReasons.SystemShutdown) 
                return;
            
            Log.Information("Windows is shutting down.");
            _isWindowsShuttingDown = true;
        }
    }
}