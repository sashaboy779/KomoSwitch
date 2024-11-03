using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using KomoSwitch.CommandPrompt;
using KomoSwitch.Models;
using KomoSwitch.Models.EventArgs;
using KomoSwitch.Services;
using Serilog;

namespace KomoSwitch.Controls
{
    public partial class WorkspacesContainer: UserControl
    {
        private readonly Dictionary<int, WorkspaceControl> _workspaceByIndex = new Dictionary<int, WorkspaceControl>();
        private readonly Storage _storage;
        private WorkspaceControl _focusedControl;
        private CancellationTokenSource _inProgressStateTokenSource;

        public WorkspacesContainer(EventListener listener, Storage storage)
        {
            listener.ConnectionEstablished += ListenerOnConnectionEstablished;
            listener.ConnectionLost += ListenerOnConnectionLost;
            listener.ConnectionFailed += ListenerOnConnectionFailed;
            listener.WorkspaceFocused += ListenerOnWorkspaceFocused;
            
            _storage = storage;
            var workspaces = storage.GetWorkspaces();

            InitializeComponent();
            SuspendLayout();

            InitializeWorkspaceControls(workspaces, isPlaceholder: true);
           
            ResumeLayout(false);
            PerformLayout();

            SetControlsInProgress();
        }

        private void InitializeWorkspaceControls(List<Workspace> workspaces, bool isPlaceholder = false)
        {
            RemovePreviouslyAddedWorkspaces();
            var controls = SetUpWorkspaceControls(workspaces, isPlaceholder);
            AddWorkspaces(controls);
        }

        private void RemovePreviouslyAddedWorkspaces()
        {
            Log.Debug("Invoke required to dispose workspaces: {Value}", InvokeRequired);

            if (InvokeRequired)
            {
                Invoke(new Action(RemovePreviouslyAddedWorkspaces));
                return;
            }
            
            try
            {
                foreach (var workspace in _workspaceByIndex.Values)
                {
                    workspace.WorkspaceClicked -= OnWorkspaceClicked;
                    Controls.Remove(workspace);
                
                    if (workspace.IsDisposed)
                    {
                        Log.Warning("WorkspaceControl was already disposed");
                    }
                    else
                    {
                        Log.Debug("Disposing WorkspaceControl");
                        workspace.Dispose();
                    }
                }
                
                _workspaceByIndex.Clear();
            }
            catch (Exception e)
            {
                Log.Error(e, "Error when disposing workspaces");
                throw;
            }
        }

        private List<WorkspaceControl> SetUpWorkspaceControls(List<Workspace> workspaces, bool isPlaceholder)
        {
            var result = new List<WorkspaceControl>(workspaces.Count);
            for (var i = workspaces.Count - 1; i >= 0; i--)
            {
                var currentWorkspace = workspaces[i];
                var control = new WorkspaceControl(currentWorkspace);
                
                control.AutoSize = true;
                control.Dock = DockStyle.Left;
                control.Margin = new Padding(0);
                control.Padding = new Padding(0, 0, 10, 0);

                if (!isPlaceholder)
                {
                    control.WorkspaceClicked += OnWorkspaceClicked;
                }

                result.Add(control);
            }

            return result;
        }

        private void AddWorkspaces(List<WorkspaceControl> controls)
        {
            Log.Debug("Invoke required to add workspaces: {Value}", InvokeRequired);

            if (InvokeRequired)
            {
                Invoke(new Action(() => AddWorkspaces(controls)));
                return;
            }

            foreach (var control in controls)
            {
                _workspaceByIndex.Add(control.WorkspaceIndex, control);

                if (control.IsFocused)
                    _focusedControl = control;
                
                Controls.Add(control);
            }
        }

        private void ListenerOnWorkspaceFocused(object sender, WorkspaceFocusedEventArgs e)
        {
            if (_focusedControl?.WorkspaceIndex == e.Index)
                return;
            
            _focusedControl?.SetFocus(false);
            _focusedControl = _workspaceByIndex[e.Index];
            _focusedControl.SetFocus(true);
        }

        private void ListenerOnConnectionEstablished(object sender, ConnectionEstablishedEventArgs e)
        {
            _inProgressStateTokenSource.Cancel();
 
            try
            {
                InitializeWorkspaceControls(e.Workspaces);
                _storage.SaveWorkspaces(e.Workspaces);
            }
            catch (Exception exception)
            {
                Log.Error(exception, "An error occured when initializing the workspaces");
            }
        }

        private void ListenerOnConnectionLost(object sender, EventArgs e)
        {
            SetControlsInProgress();
        }

        private void ListenerOnConnectionFailed(object sender, EventArgs e)
        {
            _inProgressStateTokenSource.Cancel();

            foreach (var control in _workspaceByIndex.Values)
            {
                control.SetError();
            }
        }

        private void OnWorkspaceClicked(object sender, WorkspaceFocusedEventArgs e)
        {
            if (_focusedControl?.WorkspaceIndex == e.Index)
                return;
            
            _focusedControl?.SetFocus(false);
            CommandPromptWrapper.FocusWorkspace(e.Index);
            _focusedControl = _workspaceByIndex[e.Index];
        }

        private void SetControlsInProgress()
        {
            foreach (var control in _workspaceByIndex.Values)
            {
                control.SetWaiting();
            }
            
            _inProgressStateTokenSource = new CancellationTokenSource();

            var thread = new Thread(() =>
            {
                try
                {
                    var controlsReversed = _workspaceByIndex.Values.Reverse().ToList();
                    while (true)
                    {
                        foreach (var control in controlsReversed)
                        {
                            _inProgressStateTokenSource.Token.ThrowIfCancellationRequested();
                            control.SetInProgressLine(true);

                            Thread.Sleep(100);
                            _inProgressStateTokenSource.Token.ThrowIfCancellationRequested();

                            control.SetInProgressLine(false);
                        }
                    }
                }
                catch (OperationCanceledException)
                {
                    Log.Information("In Progress state was terminated");
                }
                catch (Exception ex)
                {
                    Log.Error(ex, "An error occured: {Message}", ex.Message);
                }
            });
            
            thread.Start();
        }
    }
}
