﻿using System;
using System.Drawing;
using System.Windows.Forms;
using KomoSwitch.Models.Settings;
using KomoSwitch.Services;

namespace KomoSwitch.Controls
{
    public partial class SettingsForm : Form
    {
        private readonly WorkspacesContainer _container;
        
        public SettingsForm(WorkspacesContainer container)
        {
            InitializeComponent();

            var locations = Enum.GetNames(typeof(EStatusLineLocation));
            foreach (var location in locations)
            {
                _statusLineLocationList.Items.Add(location);
            }
            
            _statusLineLocationList.SelectedIndex = (int)Settings.Instance.StatusLineLocation - 1;
            _statusLineLocationList.SelectedIndexChanged += StatusLineLocationList_SelectedIndexChanged;

            _appMinWidth.Value = Settings.Instance.AppMinWidth;
            _appMinWidth.ValueChanged += AppMinWidth_ValueChanged;
            
            _container = container;
        }

        private void StatusLineLocationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = (ComboBox)sender;
            var selectedLocation = (EStatusLineLocation)comboBox.SelectedIndex + 1;
            Settings.Instance.StatusLineLocation = selectedLocation;
            IterateWorkspaceControls(workspace => workspace.SetStatusLineLocation(selectedLocation));
        }

        private void AppMinWidth_ValueChanged(object sender, EventArgs e)
        {
            var numericUpDown = (NumericUpDown)sender;
            Settings.Instance.AppMinWidth = Convert.ToInt32(numericUpDown.Value);
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Save();
        }

        private void IterateWorkspaceControls(Action<WorkspaceControl> action)
        {
            foreach (Control control in _container.Controls)
            {
                if (control is WorkspaceControl workspaceControl)
                {
                    action.Invoke(workspaceControl);
                }
            }
            
            _container.Refresh();
        }

        private void SelectFontButton_Click(object sender, EventArgs e)
        {
            var converter = new FontConverter();
            var dialog = new FontDialog();
            dialog.ShowEffects = false;
            dialog.ShowApply = true;
            dialog.AllowScriptChange = false;
            dialog.Font = converter.ConvertFromInvariantString(Settings.Instance.Font) as Font;
            dialog.Apply += FontDialog_OnApply;
            
            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                // ReSharper disable once AssignNullToNotNullAttribute
                var fontRaw = converter.ConvertToInvariantString(dialog.Font);
                Settings.Instance.Font = fontRaw;
                Settings.Save();
            }
            
            IterateWorkspaceControls(workspace => workspace.SetFont(Settings.Instance.Font));

            dialog.Apply -= FontDialog_OnApply;
        }

        private void FontDialog_OnApply(object sender, EventArgs e)
        {
            var dialog = (FontDialog)sender;
            IterateWorkspaceControls(workspace => workspace.SetFont(dialog.Font));
        }
    }
}