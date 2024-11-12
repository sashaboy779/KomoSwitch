using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using KomoSwitch.Models.Settings;
using KomoSwitch.Services;
using Serilog;

namespace KomoSwitch.Controls
{
    public partial class ColorSettingsControl : UserControl
    {
        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), Category("Data")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(EColorSetting.None)]
        public EColorSetting ColorSetting { get; set; }

        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), Category("Data")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue("Default")]
        public string SettingName
        {
            get => _settingName.Text;
            set => _settingName.Text = value;
        }
        
        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), Category("Data")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue("#FFFFFF")]
        public string ColorHex
        {
            get => _hexColorText.Text;
            set => _hexColorText.Text = value;
        }

        public event EventHandler ColorPicked;
        
        public ColorSettingsControl()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            RefreshColorHexOnUi();
            base.OnLoad(e);
        }

        public void RefreshColorHexOnUi()
        {
            switch (ColorSetting)
            {
                case EColorSetting.None:
                    break;
                case EColorSetting.WorkspaceDefault:
                    _hexColorText.Text = Settings.Instance.WorkspaceColors.Default;
                    _hexColorBackground.BackColor = ColorManager.Workspace.Default;
                    break;
                case EColorSetting.WorkspaceActive:
                    _hexColorText.Text = Settings.Instance.WorkspaceColors.Active;
                    _hexColorBackground.BackColor = ColorManager.Workspace.Active;
                    break;
                case EColorSetting.WorkspaceWaiting:
                    _hexColorText.Text = Settings.Instance.WorkspaceColors.Waiting;
                    _hexColorBackground.BackColor = ColorManager.Workspace.Waiting;
                    break;
                case EColorSetting.WorkspaceError:
                    _hexColorText.Text = Settings.Instance.WorkspaceColors.Error;
                    _hexColorBackground.BackColor = ColorManager.Workspace.Error;
                    break;
                case EColorSetting.WorkspaceBackgroundDefault:
                    _hexColorText.Text = Settings.Instance.WorkspaceBackgroundColors.Default;
                    _hexColorBackground.BackColor = ColorManager.WorkspaceBackground.Default;
                    break;
                case EColorSetting.WorkspaceBackgroundActive:
                    _hexColorText.Text = Settings.Instance.WorkspaceBackgroundColors.Active;
                    _hexColorBackground.BackColor = ColorManager.WorkspaceBackground.Active;
                    break;
                case EColorSetting.WorkspaceBackgroundHover:
                    _hexColorText.Text = Settings.Instance.WorkspaceBackgroundColors.Hover;
                    _hexColorBackground.BackColor = ColorManager.WorkspaceBackground.Hover;
                    break;
                case EColorSetting.WorkspaceBackgroundHoverWhenActive:
                    _hexColorText.Text = Settings.Instance.WorkspaceBackgroundColors.HoverWhenActive;
                    _hexColorBackground.BackColor = ColorManager.WorkspaceBackground.HoverWhenActive;
                    break;
                case EColorSetting.StatusLineActive:
                    _hexColorText.Text = Settings.Instance.StatusLineColors.Active;
                    _hexColorBackground.BackColor = ColorManager.StatusLine.Active;
                    break;
                case EColorSetting.StatusLineActiveWhenWaiting:
                    _hexColorText.Text = Settings.Instance.StatusLineColors.ActiveWhenWaiting;
                    _hexColorBackground.BackColor = ColorManager.StatusLine.ActiveWhenWaiting;
                    break;
                case EColorSetting.StatusLineWaiting:
                    _hexColorText.Text = Settings.Instance.StatusLineColors.Waiting;
                    _hexColorBackground.BackColor = ColorManager.StatusLine.Waiting;
                    break;
                case EColorSetting.StatusLineError:
                    _hexColorText.Text = Settings.Instance.StatusLineColors.Error;
                    _hexColorBackground.BackColor = ColorManager.StatusLine.Error;
                    break;
                default:
                    Log.Fatal("EColorSetting {Value} was not handled", ColorSetting);
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void PickColorButton_Click(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            dialog.FullOpen = true;
            dialog.Color = _hexColorBackground.BackColor;
            
            var result = dialog.ShowDialog();

            if (result != DialogResult.OK) 
                return;
            
            var color = ColorTranslator.ToHtml(dialog.Color);
                
            _hexColorText.Text = color;
            _hexColorBackground.BackColor = dialog.Color;
                
            UpdateColorInSettings(color);

            ColorPicked?.Invoke(this, EventArgs.Empty);
        }

        private void UpdateColorInSettings(string color)
        {
            switch (ColorSetting)
            {
                case EColorSetting.None:
                    break;
                case EColorSetting.WorkspaceDefault:
                    Settings.Instance.WorkspaceColors.Default = color;
                    break;
                case EColorSetting.WorkspaceActive:
                    Settings.Instance.WorkspaceColors.Active = color;
                    break;
                case EColorSetting.WorkspaceWaiting:
                    Settings.Instance.WorkspaceColors.Waiting = color;
                    break;
                case EColorSetting.WorkspaceError:
                    Settings.Instance.WorkspaceColors.Error = color;
                    break;
                case EColorSetting.WorkspaceBackgroundDefault:
                    Settings.Instance.WorkspaceBackgroundColors.Default = color;
                    break;
                case EColorSetting.WorkspaceBackgroundActive:
                    Settings.Instance.WorkspaceBackgroundColors.Active = color;
                    break;
                case EColorSetting.WorkspaceBackgroundHover:
                    Settings.Instance.WorkspaceBackgroundColors.Hover = color;
                    break;
                case EColorSetting.WorkspaceBackgroundHoverWhenActive:
                    Settings.Instance.WorkspaceBackgroundColors.HoverWhenActive = color;
                    break;
                case EColorSetting.StatusLineActive:
                    Settings.Instance.StatusLineColors.Active = color;
                    break;
                case EColorSetting.StatusLineActiveWhenWaiting:
                    Settings.Instance.StatusLineColors.ActiveWhenWaiting = color;
                    break;
                case EColorSetting.StatusLineWaiting:
                    Settings.Instance.StatusLineColors.Waiting = color;
                    break;
                case EColorSetting.StatusLineError:
                    Settings.Instance.StatusLineColors.Error = color;
                    break;
                default:
                    Log.Fatal("EColorSetting {Value} was not handled", ColorSetting);
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void RestButton_Click(object sender, EventArgs e)
        {
            ResetColorInSettings();
            RefreshColorHexOnUi();
            
            ColorPicked?.Invoke(this, EventArgs.Empty);
        }
        
        private void ResetColorInSettings()
        {
            var defaultSettings = new Settings();
            switch (ColorSetting)
            {
                case EColorSetting.None:
                    break;
                case EColorSetting.WorkspaceDefault:
                    Settings.Instance.WorkspaceColors.Default = defaultSettings.WorkspaceColors.Default;
                    break;
                case EColorSetting.WorkspaceActive:
                    Settings.Instance.WorkspaceColors.Active = defaultSettings.WorkspaceColors.Active;
                    break;
                case EColorSetting.WorkspaceWaiting:
                    Settings.Instance.WorkspaceColors.Waiting = defaultSettings.WorkspaceColors.Waiting;
                    break;
                case EColorSetting.WorkspaceError:
                    Settings.Instance.WorkspaceColors.Error = defaultSettings.WorkspaceColors.Error;
                    break;
                case EColorSetting.WorkspaceBackgroundDefault:
                    Settings.Instance.WorkspaceBackgroundColors.Default = defaultSettings.WorkspaceBackgroundColors.Default;
                    break;
                case EColorSetting.WorkspaceBackgroundActive:
                    Settings.Instance.WorkspaceBackgroundColors.Active = defaultSettings.WorkspaceBackgroundColors.Active;
                    break;
                case EColorSetting.WorkspaceBackgroundHover:
                    Settings.Instance.WorkspaceBackgroundColors.Hover = defaultSettings.WorkspaceBackgroundColors.Hover;
                    break;
                case EColorSetting.WorkspaceBackgroundHoverWhenActive:
                    Settings.Instance.WorkspaceBackgroundColors.HoverWhenActive = defaultSettings.WorkspaceBackgroundColors.HoverWhenActive;
                    break;
                case EColorSetting.StatusLineActive:
                    Settings.Instance.StatusLineColors.Active = defaultSettings.StatusLineColors.Active;
                    break;
                case EColorSetting.StatusLineActiveWhenWaiting:
                    Settings.Instance.StatusLineColors.ActiveWhenWaiting = defaultSettings.StatusLineColors.ActiveWhenWaiting;
                    break;
                case EColorSetting.StatusLineWaiting:
                    Settings.Instance.StatusLineColors.Waiting = defaultSettings.StatusLineColors.Waiting;
                    break;
                case EColorSetting.StatusLineError:
                    Settings.Instance.StatusLineColors.Error = defaultSettings.StatusLineColors.Error;
                    break;
                default:
                    Log.Fatal("EColorSetting {Value} was not handled", ColorSetting);
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
