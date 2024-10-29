using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using KomoSwitch.Models;
using KomoSwitch.Models.EventArgs;
using Serilog;

namespace KomoSwitch.Controls
{
    public partial class WorkspacesContainer: UserControl
    {
        private readonly Dictionary<int, WorkspaceControl> _controls = new Dictionary<int, WorkspaceControl>();
        private WorkspaceControl _focusedControl;
        private CancellationTokenSource _inProgressStateTokenSource;
        
        public WorkspacesContainer(EventListener listener)
        {
            listener.ConnectionEstablished += ListenerOnConnectionEstablished;
            listener.ConnectionLost += ListenerOnConnectionLost;
            listener.ConnectionFailed += ListenerOnConnectionFailed;
            listener.WorkspaceFocused += ListenerOnWorkspaceFocused;
            
            InitializeComponent();
            SuspendLayout();
            
            InitializeWorkspaceControls();
           
            ResumeLayout(false);
            PerformLayout();

            SetControlsInProgress();
        }

        private void InitializeWorkspaceControls()
        {
            var workspaceStates = new List<WorkspaceState>()
            {
                new WorkspaceState("1", 0, true),
                new WorkspaceState("2", 1, false),
                new WorkspaceState("3", 2, false),
                new WorkspaceState("4", 3, false),
                new WorkspaceState("5", 4, false),
                new WorkspaceState("6", 5, false),
                new WorkspaceState("7", 6, false),
                new WorkspaceState("8", 7, false),
                new WorkspaceState("9", 8, false),
            };
            
            for (var i = workspaceStates.Count - 1; i >= 0; i--)
            {
                var currentWorkspace = workspaceStates[i];
                var control = new WorkspaceControl(currentWorkspace);
                
                control.AutoSize = true;
                control.Dock = DockStyle.Left;
                control.Margin = new Padding(0);
                control.Padding = new Padding(0, 0, 10, 0);
                
                control.WorkspaceClicked += OnWorkspaceClicked;
                control.SetWaiting();
            
                Controls.Add(control);
                _controls.Add(control.WorkspaceIndex, control);

                if (currentWorkspace.IsFocused)
                {
                    _focusedControl = control;
                }
            }
        }

        private void ListenerOnWorkspaceFocused(object sender, WorkspaceFocusedEventArgs e)
        {
            if (_focusedControl?.WorkspaceIndex == e.Index)
                return;
            
            _focusedControl?.SetFocus(false);
            _focusedControl = _controls[e.Index];
            _focusedControl.SetFocus(true);
        }

        private void ListenerOnConnectionEstablished(object sender, EventArgs e)
        {
            _inProgressStateTokenSource.Cancel();

            foreach (var control in _controls.Values)
            {
                control.SetResume();
            }
        }

        private void ListenerOnConnectionLost(object sender, EventArgs e)
        {
            SetControlsInProgress();
        }

        private void ListenerOnConnectionFailed(object sender, EventArgs e)
        {
            _inProgressStateTokenSource.Cancel();

            foreach (var control in _controls.Values)
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
            _focusedControl = _controls[e.Index];
        }

        private void SetControlsInProgress()
        {
            foreach (var control in _controls.Values)
            {
                control.SetWaiting();
            }
            
            _inProgressStateTokenSource = new CancellationTokenSource();

            var thread = new Thread(() =>
            {
                try
                {
                    var controlsReversed = _controls.Values.Reverse().ToList();
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
