using System;
using System.Drawing;
using System.Windows.Forms;
using KomoSwitch.Models;

namespace KomoSwitch
{
    public partial class WorkspaceControl : UserControl
    {
        /// <summary>
        /// Fires when user switches to another workspace
        /// </summary>
        public event EventHandler<WorkspaceFocusedEventArgs> WorkspaceFocused;
        
        private readonly Color _backgroundDefaultColor = Color.Transparent;
        private readonly Color _backgroundHoverColor = Color.FromArgb(25, Color.Gray);
        private readonly Color _backgroundFocusedColor = Color.FromArgb(50, Color.Gray);
        private readonly Color _backgroundHoverWhenFocusedColor = Color.FromArgb(75, Color.Gray);
        
        private readonly Color _labelDefaultColor = Color.White;
        private readonly Color _labelFocusedColor = Color.FromArgb(151, 233, 239);

        private readonly int _workspaceIndex;
        
        public WorkspaceControl(WorkspaceState workspace)
        {
            InitializeComponent();
            
            _workspaceIndex = workspace.Index;
            lbl_name.Text = workspace.Name;

            if (workspace.IsFocused)
            {
                SetFocus(true);
            }
        }

        private void lbl_name_MouseLeave(object sender, EventArgs e)
        {
            pnl_background.BackColor = IsControlFocused()
                ? _backgroundFocusedColor
                : _backgroundDefaultColor;
        }

        private void lbl_name_MouseEnter(object sender, EventArgs e)
        {
            pnl_background.BackColor = IsControlFocused()
                ? _backgroundHoverWhenFocusedColor
                : _backgroundHoverColor;
        }

        private void lbl_name_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            var isFocused = IsControlFocused();
            
            if (isFocused)
                return;
            
            SetFocus(true);
            
            WorkspaceFocused?.Invoke(this, new WorkspaceFocusedEventArgs(_workspaceIndex));
        }

        public void SetFocus(bool shouldFocus)
        {
            lbl_name.ForeColor = shouldFocus
                ? _labelFocusedColor
                : _labelDefaultColor;

            pnl_background.BackColor = shouldFocus
                ? _backgroundHoverWhenFocusedColor
                : _backgroundDefaultColor;
        }
        
        private bool IsControlFocused()
        {
            return lbl_name.ForeColor != _labelDefaultColor;
        }
    }
}
