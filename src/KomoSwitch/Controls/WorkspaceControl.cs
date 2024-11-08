﻿using System;
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

        public Panel StatusLine => pnl_line;
        public Label WorkspaceNameText => lbl_name;
        
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
            lbl_name.Text = workspace.Name;
            pnl_line.Dock = Settings.Instance.StatusLineLocation == EStatusLineLocation.Bottom
                ? DockStyle.Bottom
                : DockStyle.Top;

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

            _toolTip.SetToolTip(lbl_name, "Connecting to komorebi...");
            lbl_name.ForeColor = _waitingColor;
            pnl_line.BackColor = _waitingColor;
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
            if (InvokeRequired)
            {
                Action setInProgressLineSafe = delegate { SetInProgressLine(isInProgress); };
                Invoke(setInProgressLineSafe);
                return;
            }
            
            pnl_line.BackColor = isInProgress
                ? Color.WhiteSmoke
                : _waitingColor;
        }
        
        private bool IsControlFocused()
        {
            return lbl_name.ForeColor != _labelDefaultColor;
        }
    }
}
