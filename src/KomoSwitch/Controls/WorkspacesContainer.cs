using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using KomoSwitch.Models;

namespace KomoSwitch
{
    public partial class WorkspacesContainer: UserControl
    {
        private WorkspaceControl _focusedControl;
        
        public WorkspacesContainer(CSDeskBand.CSDeskBandWin w)
        {
            var workspaces = new List<WorkspaceState>()
            {
                new WorkspaceState("1", 0, false),
                new WorkspaceState("2", 1, true),
                new WorkspaceState("3", 2, false),
                new WorkspaceState("4", 3, false),
                new WorkspaceState("5", 4, false),
                new WorkspaceState("6", 5, false),
                new WorkspaceState("7", 6, false),
                new WorkspaceState("8", 7, false),
                new WorkspaceState("9", 8, false),
            };
            
            InitializeComponent();
            
            SuspendLayout();

            for (var i = workspaces.Count - 1; i >= 0; i--)
            {
                var workspace = workspaces[i];
                var control = new WorkspaceControl(workspace);
                
                control.AutoSize = true;
                control.Dock = DockStyle.Left;
                control.Margin = new Padding(0);
                control.Padding = new Padding(0, 0, 10, 0);
                
                control.WorkspaceFocused += OnWorkspaceFocused;
            
                Controls.Add(control);

                if (workspace.IsFocused)
                {
                    _focusedControl = control;
                }
            }
            
            ResumeLayout(false);
            PerformLayout();
        }

        private void OnWorkspaceFocused(object sender, WorkspaceFocusedEventArgs e)
        {
            _focusedControl?.SetFocus(false);
            CommandPromptWrapper.FocusWorkspace(e.Index);
            _focusedControl = (WorkspaceControl)sender;
        }
    }
}
