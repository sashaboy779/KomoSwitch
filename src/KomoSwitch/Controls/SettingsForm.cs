using System;
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
    }
}