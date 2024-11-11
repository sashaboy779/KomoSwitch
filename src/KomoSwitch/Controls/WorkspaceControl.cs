using System;
using System.Drawing;
using System.Windows.Forms;
using KomoSwitch.Models;
using KomoSwitch.Models.EventArgs;
using KomoSwitch.Models.Settings;
using KomoSwitch.Services;

namespace KomoSwitch.Controls
{
    public partial class WorkspaceControl : UserControl
    {
        /// <summary>
        /// Fires when user switches to another workspace
        /// </summary>
        public event EventHandler<WorkspaceFocusedEventArgs> WorkspaceClicked;
       
        /// <summary>
        /// Index of the workspace this control is associated to
        /// </summary>
        public readonly int WorkspaceIndex;
        
        /// <summary>
        /// Indicates if the control is focused
        /// </summary>
        public bool IsFocused { get; private set; }

        private readonly ToolTip _toolTip;
        private bool _blocked;
        
        public WorkspaceControl(Workspace workspace)
        {
            InitializeComponent();
            
            WorkspaceIndex = workspace.Index;
            _workspaceName.Text = workspace.Name;
            _workspaceBackground.BackColor = ColorManager.WorkspaceBackground.Default;
            
            SetAccentColors();
            SetStatusLineLocation(Settings.Instance.StatusLineLocation);
            SetFont(Settings.Instance.Font);
            SetWorkspaceWidth(Settings.Instance.WorkspaceWidth);
            SetWorkspaceGap(Settings.Instance.WorkspaceGap);

            if (workspace.IsFocused)
            {
                SetFocus(true);
            }
            
            _toolTip = new ToolTip();
            _toolTip.InitialDelay = 1;
            _toolTip.ShowAlways = true;
        }

        private void lbl_name_MouseLeave(object sender, EventArgs e)
        {
            if (_blocked)
                return;

            _workspaceBackground.BackColor = IsFocused
                ? ColorManager.WorkspaceBackground.Active
                : ColorManager.WorkspaceBackground.Default;
        }

        private void lbl_name_MouseEnter(object sender, EventArgs e)
        {
            if (_blocked)
                return;

            _workspaceBackground.BackColor = IsFocused
                ? ColorManager.WorkspaceBackground.HoverWhenActive
                : ColorManager.WorkspaceBackground.Hover;
        }

        private void lbl_name_MouseClick(object sender, MouseEventArgs e)
        {
            if (_blocked)
                return;

            if (e.Button != MouseButtons.Left)
                return;

            
            if (IsFocused)
                return;
            
            SetFocus(true);
            
            WorkspaceClicked?.Invoke(this, new WorkspaceFocusedEventArgs(WorkspaceIndex));
        }

        public void SetFocus(bool shouldFocus)
        {
            if (_blocked)
                return;

            _workspaceName.ForeColor = shouldFocus
                ? ColorManager.Workspace.Active
                : ColorManager.Workspace.Default;

            _workspaceBackground.BackColor = shouldFocus
                ? ColorManager.WorkspaceBackground.HoverWhenActive
                : ColorManager.WorkspaceBackground.Default;

            IsFocused = shouldFocus;
        }

        public void SetWaiting()
        {
            if (InvokeRequired)
            {
                Action setWaitingSafe = SetWaiting;
                Invoke(setWaitingSafe);
                return;
            }
            
            _blocked = true;

            _toolTip.SetToolTip(_workspaceName, "Connecting to komorebi...");
            _workspaceName.ForeColor = ColorManager.Workspace.Waiting;
            _statusLine.BackColor = ColorManager.StatusLine.Waiting;
            _workspaceBackground.BackColor = ColorManager.WorkspaceBackground.Default;
        }
        
        public void SetError()
        {
            _blocked = true;
            
            _toolTip.SetToolTip(_workspaceName, "Unable to connect to komorebi");
            
            _workspaceName.ForeColor = ColorManager.Workspace.Error;
            _statusLine.BackColor = ColorManager.StatusLine.Error;
            _workspaceBackground.BackColor = ColorManager.WorkspaceBackground.Default;
        }

        public void SetInProgressLine(bool isInProgress)
        {
            if (InvokeRequired)
            {
                Action setInProgressLineSafe = delegate { SetInProgressLine(isInProgress); };
                Invoke(setInProgressLineSafe);
                return;
            }
            
            _statusLine.BackColor = isInProgress
                ? ColorManager.StatusLine.ActiveWhenWaiting
                : ColorManager.StatusLine.Waiting;
        }

        public void SetStatusLineLocation(EStatusLineLocation location)
        {
            _statusLine.Dock = location == EStatusLineLocation.Bottom
                ? DockStyle.Bottom
                : DockStyle.Top;
        }

        public void SetFont(Font font)
        {
            _workspaceName.Font = font;
        }
        
        public void SetFont(string fontRaw)
        {
            var fontObject = new FontConverter().ConvertFromInvariantString(fontRaw);
            if (fontObject is Font font) 
                _workspaceName.Font = font;
        }

        public void SetWorkspaceWidth(int width)
        {
            _workspaceName.Width = width;
        }

        public void SetWorkspaceGap(int gap)
        {
            Padding = new Padding(gap, 0, gap, 0);
        }

        public void SetAccentColors()
        {
            _statusLine.BackColor = ColorManager.StatusLine.Active;
            
            _workspaceName.ForeColor = IsFocused 
                ? ColorManager.Workspace.Active
                : ColorManager.Workspace.Default;
        }

        public void RefreshColors()
        {
            SetAccentColors();
            
            _workspaceBackground.BackColor = IsFocused
                ? ColorManager.WorkspaceBackground.Active
                : ColorManager.WorkspaceBackground.Default;
        }
    }
}
