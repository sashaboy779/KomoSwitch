using System;
using System.Drawing;
using System.Windows.Forms;
using KomoSwitch.Models.Settings;
using KomoSwitch.Services;

namespace KomoSwitch.Controls
{
    public partial class SettingsForm : Form
    {
        private readonly WorkspacesContainer _container;
        private readonly ColorSettingsControl _activeWorkspaceNameColorSetting;
        private readonly ColorSettingsControl _activeStatusLineColorSetting;
        
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

            _workspaceWidth.Value = Settings.Instance.WorkspaceWidth;
            _workspaceWidth.ValueChanged += WorkspaceWidth_ValueChanged;

            _workspaceGap.Value = Settings.Instance.WorkspaceGap;
            _workspaceGap.ValueChanged += WorkspaceGap_ValueChanged;

            _syncWithTheme.Checked = Settings.Instance.SyncWithWindowsTheme;
            _syncWithTheme.CheckedChanged += SyncWithTheme_CheckedChanged;

            foreach (var control in _workspaceColors.Controls)
            {
                if (control is ColorSettingsControl settingsControl 
                    && settingsControl.ColorSetting == EColorSetting.WorkspaceActive)
                {
                    _activeWorkspaceNameColorSetting = settingsControl;
                    break;
                }
            }
            
            foreach (var control in _statusLineColors.Controls)
            {
                if (control is ColorSettingsControl settingsControl 
                    && settingsControl.ColorSetting == EColorSetting.StatusLineActive)
                {
                    _activeStatusLineColorSetting = settingsControl;
                    break;
                }
            }

            UpdateDependentOnSyncWithWindowsThemeControls(!Settings.Instance.SyncWithWindowsTheme);
            _container = container;
        }

        private void UpdateDependentOnSyncWithWindowsThemeControls(bool enabled)
        {
            _activeWorkspaceNameColorSetting.Enabled = enabled;
            _activeStatusLineColorSetting.Enabled = enabled;
            
            _activeWorkspaceNameColorSetting.RefreshColorHexOnUi();
            _activeStatusLineColorSetting.RefreshColorHexOnUi();
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

        private void WorkspaceWidth_ValueChanged(object sender, EventArgs e)
        {
            var numericUpDown = (NumericUpDown)sender;
            var width = Convert.ToInt32(numericUpDown.Value);
            Settings.Instance.WorkspaceWidth = width;
            IterateWorkspaceControls(workspace => workspace.SetWorkspaceWidth(width));
        }

        private void WorkspaceGap_ValueChanged(object sender, EventArgs e)
        {
            var numericUpDown = (NumericUpDown)sender;
            var gap = Convert.ToInt32(numericUpDown.Value);
            Settings.Instance.WorkspaceGap = gap;
            IterateWorkspaceControls(workspace => workspace.SetWorkspaceGap(gap));
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
        
        private void SyncWithTheme_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = (CheckBox)sender;
            Settings.Instance.SyncWithWindowsTheme = checkBox.Checked;

            var color = ColorManager.Windows.AccentColor;
            
            Settings.Instance.WorkspaceColors.Active = ColorTranslator.ToHtml(color);
            Settings.Instance.StatusLineColors.Active = ColorTranslator.ToHtml(color);
            
            UpdateDependentOnSyncWithWindowsThemeControls(!Settings.Instance.SyncWithWindowsTheme);
            
            IterateWorkspaceControls(workspace => workspace.SetAccentColors());
        }

        private void FontDialog_OnApply(object sender, EventArgs e)
        {
            var dialog = (FontDialog)sender;
            IterateWorkspaceControls(workspace => workspace.SetFont(dialog.Font));
        }

        private void ColorSettingsControl_ColorPicked(object sender, EventArgs e)
        {
            IterateWorkspaceControls(workspace => workspace.RefreshColors());
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

        private void SettingsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Save();
        }
    }
}