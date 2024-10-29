using System;
using System.Drawing;
using System.Windows.Forms;
using KomoSwitch.Models;
using KomoSwitch.Models.EventArgs;

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
        
        private readonly Color _backgroundDefaultColor = Color.Transparent;
        private readonly Color _backgroundHoverColor = Color.FromArgb(25, Color.Gray);
        private readonly Color _backgroundFocusedColor = Color.FromArgb(50, Color.Gray);
        private readonly Color _backgroundHoverWhenFocusedColor = Color.FromArgb(75, Color.Gray);
        private readonly Color _labelDefaultColor = Color.White;
        private readonly Color _labelFocusedColor = Color.FromArgb(151, 233, 239);
        private readonly Color _lineDefaultColor = Color.FromArgb(151, 233, 239);
        private readonly Color _waitingColor = Color.DimGray;
        private readonly Color _errorColor = Color.FromArgb(185,49,57);

        private readonly ToolTip _toolTip;
        private bool _blocked;
        
        public WorkspaceControl(WorkspaceState workspace)
        {
            InitializeComponent();
            
            WorkspaceIndex = workspace.Index;
            lbl_name.Text = workspace.Name;

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

            pnl_background.BackColor = IsControlFocused()
                ? _backgroundFocusedColor
                : _backgroundDefaultColor;
        }

        private void lbl_name_MouseEnter(object sender, EventArgs e)
        {
            if (_blocked)
                return;

            pnl_background.BackColor = IsControlFocused()
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

            lbl_name.ForeColor = shouldFocus
                ? _labelFocusedColor
                : _labelDefaultColor;

            pnl_background.BackColor = shouldFocus
                ? _backgroundHoverWhenFocusedColor
                : _backgroundDefaultColor;
        }

        public void SetWaiting()
        {
            _blocked = true;
            
            _toolTip.SetToolTip(lbl_name, "Connecting to komorebi");
            
            lbl_name.ForeColor = _waitingColor;
            pnl_line.BackColor = _waitingColor;
            pnl_background.BackColor = _backgroundDefaultColor;
        }
        
        public void SetResume()
        {
            _blocked = false;
            
            _toolTip.SetToolTip(lbl_name, null);
            
            lbl_name.ForeColor = _labelDefaultColor;
            pnl_line.BackColor = _lineDefaultColor;
            pnl_background.BackColor = _backgroundDefaultColor;
        }
        
        public void SetError()
        {
            _blocked = true;
            
            _toolTip.SetToolTip(lbl_name, "Unable to connect to komorebi");
            
            lbl_name.ForeColor = _errorColor;
            pnl_line.BackColor = _errorColor;
            pnl_background.BackColor = _backgroundDefaultColor;
        }

        public void SetInProgressLine(bool isInProgress)
        {
            var color = isInProgress
                ? Color.WhiteSmoke
                : _waitingColor;

            if (pnl_line.InvokeRequired)
            {
                pnl_line.Invoke(new Action(() => pnl_line.BackColor = color));
            }
            else
            {
                pnl_line.BackColor = color;
            }
        }
        
        private bool IsControlFocused()
        {
            return lbl_name.ForeColor != _labelDefaultColor;
        }
    }
}
