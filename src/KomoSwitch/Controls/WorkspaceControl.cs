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

        private readonly Color _backgroundDefaultColor = Color.Transparent;
        private readonly Color _backgroundHoverColor = Color.FromArgb(25, 128, 128, 128);
        private readonly Color _backgroundFocusedColor = Color.FromArgb(50, 128, 128, 128);
        private readonly Color _backgroundHoverWhenFocusedColor = Color.FromArgb(75, 128, 128, 128);
        private readonly Color _labelDefaultColor = Color.White;
        private readonly Color _labelFocusedColor = Color.FromArgb(151, 233, 239);
        private readonly Color _waitingColor = Color.DimGray;
        private readonly Color _errorColor = Color.FromArgb(185,49,57);

        private readonly ToolTip _toolTip;
        private bool _blocked;
        
        public WorkspaceControl(Workspace workspace)
        {
            InitializeComponent();
            
            WorkspaceIndex = workspace.Index;
            _workspaceName.Text = workspace.Name;
            
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

            _workspaceBackground.BackColor = IsControlFocused()
                ? _backgroundFocusedColor
                : _backgroundDefaultColor;
        }

        private void lbl_name_MouseEnter(object sender, EventArgs e)
        {
            if (_blocked)
                return;

            _workspaceBackground.BackColor = IsControlFocused()
                ? _backgroundHoverWhenFocusedColor
                : _backgroundHoverColor;
        }

        private void lbl_name_MouseClick(object sender, MouseEventArgs e)
        {
            if (_blocked)
                return;

            if (e.Button != MouseButtons.Left)
                return;

            var isFocused = IsControlFocused();
            
            if (isFocused)
                return;
            
            SetFocus(true);
            
            WorkspaceClicked?.Invoke(this, new WorkspaceFocusedEventArgs(WorkspaceIndex));
        }

        public void SetFocus(bool shouldFocus)
        {
            if (_blocked)
                return;

            _workspaceName.ForeColor = shouldFocus
                ? _labelFocusedColor
                : _labelDefaultColor;

            _workspaceBackground.BackColor = shouldFocus
                ? _backgroundHoverWhenFocusedColor
                : _backgroundDefaultColor;

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
            _workspaceName.ForeColor = _waitingColor;
            _statusLine.BackColor = _waitingColor;
            _workspaceBackground.BackColor = _backgroundDefaultColor;
        }
        
        public void SetError()
        {
            _blocked = true;
            
            _toolTip.SetToolTip(_workspaceName, "Unable to connect to komorebi");
            
            _workspaceName.ForeColor = _errorColor;
            _statusLine.BackColor = _errorColor;
            _workspaceBackground.BackColor = _backgroundDefaultColor;
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
                ? Color.WhiteSmoke
                : _waitingColor;
        }
        
        private bool IsControlFocused()
        {
            return _workspaceName.ForeColor != _labelDefaultColor;
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
    }
}
