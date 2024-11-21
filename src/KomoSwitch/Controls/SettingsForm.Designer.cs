using System.ComponentModel;

namespace KomoSwitch.Controls
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this._statusLineColors = new System.Windows.Forms.GroupBox();
            this.colorSettingsControl10 = new KomoSwitch.Controls.ColorSettingsControl();
            this.colorSettingsControl11 = new KomoSwitch.Controls.ColorSettingsControl();
            this.colorSettingsControl12 = new KomoSwitch.Controls.ColorSettingsControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this._workspaceBackgroundColors = new System.Windows.Forms.GroupBox();
            this.colorSettingsControl5 = new KomoSwitch.Controls.ColorSettingsControl();
            this.colorSettingsControl6 = new KomoSwitch.Controls.ColorSettingsControl();
            this.colorSettingsControl7 = new KomoSwitch.Controls.ColorSettingsControl();
            this.colorSettingsControl8 = new KomoSwitch.Controls.ColorSettingsControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this._workspaceColors = new System.Windows.Forms.GroupBox();
            this.colorSettingsControl4 = new KomoSwitch.Controls.ColorSettingsControl();
            this.colorSettingsControl3 = new KomoSwitch.Controls.ColorSettingsControl();
            this.colorSettingsControl2 = new KomoSwitch.Controls.ColorSettingsControl();
            this.colorSettingsControl1 = new KomoSwitch.Controls.ColorSettingsControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._workspaceWidth = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this._syncWithTheme = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this._workspaceGap = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._appMinWidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this._selectFontButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this._statusLineLocationList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this._statusLineColors.SuspendLayout();
            this._workspaceBackgroundColors.SuspendLayout();
            this._workspaceColors.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._workspaceWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._workspaceGap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._appMinWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this._statusLineColors);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this._workspaceBackgroundColors);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this._workspaceColors);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.panel1.Size = new System.Drawing.Size(650, 471);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(8, 852);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(613, 15);
            this.panel5.TabIndex = 7;
            // 
            // _statusLineColors
            // 
            this._statusLineColors.Controls.Add(this.colorSettingsControl10);
            this._statusLineColors.Controls.Add(this.colorSettingsControl11);
            this._statusLineColors.Controls.Add(this.colorSettingsControl12);
            this._statusLineColors.Dock = System.Windows.Forms.DockStyle.Top;
            this._statusLineColors.Location = new System.Drawing.Point(8, 706);
            this._statusLineColors.Margin = new System.Windows.Forms.Padding(2);
            this._statusLineColors.Name = "_statusLineColors";
            this._statusLineColors.Padding = new System.Windows.Forms.Padding(2);
            this._statusLineColors.Size = new System.Drawing.Size(613, 146);
            this._statusLineColors.TabIndex = 5;
            this._statusLineColors.TabStop = false;
            this._statusLineColors.Text = "Status line colors";
            // 
            // colorSettingsControl10
            // 
            this.colorSettingsControl10.AutoSize = true;
            this.colorSettingsControl10.ColorHex = "#B93139";
            this.colorSettingsControl10.ColorSetting = KomoSwitch.Models.Settings.EColorSetting.StatusLineError;
            this.colorSettingsControl10.Dock = System.Windows.Forms.DockStyle.Top;
            this.colorSettingsControl10.Location = new System.Drawing.Point(2, 98);
            this.colorSettingsControl10.Margin = new System.Windows.Forms.Padding(0);
            this.colorSettingsControl10.Name = "colorSettingsControl10";
            this.colorSettingsControl10.Padding = new System.Windows.Forms.Padding(15, 5, 12, 5);
            this.colorSettingsControl10.SettingName = "Error";
            this.colorSettingsControl10.Size = new System.Drawing.Size(609, 38);
            this.colorSettingsControl10.TabIndex = 2;
            this.colorSettingsControl10.ColorPicked += new System.EventHandler(this.ColorSettingsControl_ColorPicked);
            // 
            // colorSettingsControl11
            // 
            this.colorSettingsControl11.AutoSize = true;
            this.colorSettingsControl11.ColorHex = "#696969";
            this.colorSettingsControl11.ColorSetting = KomoSwitch.Models.Settings.EColorSetting.StatusLineWaiting;
            this.colorSettingsControl11.Dock = System.Windows.Forms.DockStyle.Top;
            this.colorSettingsControl11.Location = new System.Drawing.Point(2, 60);
            this.colorSettingsControl11.Margin = new System.Windows.Forms.Padding(0);
            this.colorSettingsControl11.Name = "colorSettingsControl11";
            this.colorSettingsControl11.Padding = new System.Windows.Forms.Padding(15, 5, 12, 5);
            this.colorSettingsControl11.SettingName = "Waiting";
            this.colorSettingsControl11.Size = new System.Drawing.Size(609, 38);
            this.colorSettingsControl11.TabIndex = 1;
            this.colorSettingsControl11.ColorPicked += new System.EventHandler(this.ColorSettingsControl_ColorPicked);
            // 
            // colorSettingsControl12
            // 
            this.colorSettingsControl12.AutoSize = true;
            this.colorSettingsControl12.ColorHex = "#3ACE09";
            this.colorSettingsControl12.ColorSetting = KomoSwitch.Models.Settings.EColorSetting.StatusLineActive;
            this.colorSettingsControl12.Dock = System.Windows.Forms.DockStyle.Top;
            this.colorSettingsControl12.Location = new System.Drawing.Point(2, 17);
            this.colorSettingsControl12.Margin = new System.Windows.Forms.Padding(0);
            this.colorSettingsControl12.Name = "colorSettingsControl12";
            this.colorSettingsControl12.Padding = new System.Windows.Forms.Padding(15, 10, 12, 5);
            this.colorSettingsControl12.SettingName = "Active";
            this.colorSettingsControl12.Size = new System.Drawing.Size(609, 43);
            this.colorSettingsControl12.TabIndex = 0;
            this.colorSettingsControl12.ColorPicked += new System.EventHandler(this.ColorSettingsControl_ColorPicked);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(8, 691);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(613, 15);
            this.panel4.TabIndex = 6;
            // 
            // _workspaceBackgroundColors
            // 
            this._workspaceBackgroundColors.Controls.Add(this.colorSettingsControl5);
            this._workspaceBackgroundColors.Controls.Add(this.colorSettingsControl6);
            this._workspaceBackgroundColors.Controls.Add(this.colorSettingsControl7);
            this._workspaceBackgroundColors.Controls.Add(this.colorSettingsControl8);
            this._workspaceBackgroundColors.Dock = System.Windows.Forms.DockStyle.Top;
            this._workspaceBackgroundColors.Location = new System.Drawing.Point(8, 505);
            this._workspaceBackgroundColors.Margin = new System.Windows.Forms.Padding(2);
            this._workspaceBackgroundColors.Name = "_workspaceBackgroundColors";
            this._workspaceBackgroundColors.Padding = new System.Windows.Forms.Padding(2);
            this._workspaceBackgroundColors.Size = new System.Drawing.Size(613, 186);
            this._workspaceBackgroundColors.TabIndex = 4;
            this._workspaceBackgroundColors.TabStop = false;
            this._workspaceBackgroundColors.Text = "Workspace background colors";
            // 
            // colorSettingsControl5
            // 
            this.colorSettingsControl5.AutoSize = true;
            this.colorSettingsControl5.ColorHex = "#4B808080";
            this.colorSettingsControl5.ColorSetting = KomoSwitch.Models.Settings.EColorSetting.WorkspaceBackgroundHoverWhenActive;
            this.colorSettingsControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.colorSettingsControl5.Location = new System.Drawing.Point(2, 136);
            this.colorSettingsControl5.Margin = new System.Windows.Forms.Padding(0);
            this.colorSettingsControl5.Name = "colorSettingsControl5";
            this.colorSettingsControl5.Padding = new System.Windows.Forms.Padding(15, 5, 12, 5);
            this.colorSettingsControl5.SettingName = "Hover when active";
            this.colorSettingsControl5.Size = new System.Drawing.Size(609, 38);
            this.colorSettingsControl5.TabIndex = 3;
            this.colorSettingsControl5.ColorPicked += new System.EventHandler(this.ColorSettingsControl_ColorPicked);
            // 
            // colorSettingsControl6
            // 
            this.colorSettingsControl6.AutoSize = true;
            this.colorSettingsControl6.ColorHex = "#19808080";
            this.colorSettingsControl6.ColorSetting = KomoSwitch.Models.Settings.EColorSetting.WorkspaceBackgroundHover;
            this.colorSettingsControl6.Dock = System.Windows.Forms.DockStyle.Top;
            this.colorSettingsControl6.Location = new System.Drawing.Point(2, 98);
            this.colorSettingsControl6.Margin = new System.Windows.Forms.Padding(0);
            this.colorSettingsControl6.Name = "colorSettingsControl6";
            this.colorSettingsControl6.Padding = new System.Windows.Forms.Padding(15, 5, 12, 5);
            this.colorSettingsControl6.SettingName = "Hover";
            this.colorSettingsControl6.Size = new System.Drawing.Size(609, 38);
            this.colorSettingsControl6.TabIndex = 2;
            this.colorSettingsControl6.ColorPicked += new System.EventHandler(this.ColorSettingsControl_ColorPicked);
            // 
            // colorSettingsControl7
            // 
            this.colorSettingsControl7.AutoSize = true;
            this.colorSettingsControl7.ColorHex = "#32808080";
            this.colorSettingsControl7.ColorSetting = KomoSwitch.Models.Settings.EColorSetting.WorkspaceBackgroundActive;
            this.colorSettingsControl7.Dock = System.Windows.Forms.DockStyle.Top;
            this.colorSettingsControl7.Location = new System.Drawing.Point(2, 60);
            this.colorSettingsControl7.Margin = new System.Windows.Forms.Padding(0);
            this.colorSettingsControl7.Name = "colorSettingsControl7";
            this.colorSettingsControl7.Padding = new System.Windows.Forms.Padding(15, 5, 12, 5);
            this.colorSettingsControl7.SettingName = "Active";
            this.colorSettingsControl7.Size = new System.Drawing.Size(609, 38);
            this.colorSettingsControl7.TabIndex = 1;
            this.colorSettingsControl7.ColorPicked += new System.EventHandler(this.ColorSettingsControl_ColorPicked);
            // 
            // colorSettingsControl8
            // 
            this.colorSettingsControl8.AutoSize = true;
            this.colorSettingsControl8.ColorHex = "#00000000";
            this.colorSettingsControl8.ColorSetting = KomoSwitch.Models.Settings.EColorSetting.WorkspaceBackgroundDefault;
            this.colorSettingsControl8.Dock = System.Windows.Forms.DockStyle.Top;
            this.colorSettingsControl8.Location = new System.Drawing.Point(2, 17);
            this.colorSettingsControl8.Margin = new System.Windows.Forms.Padding(0);
            this.colorSettingsControl8.Name = "colorSettingsControl8";
            this.colorSettingsControl8.Padding = new System.Windows.Forms.Padding(15, 10, 12, 5);
            this.colorSettingsControl8.Size = new System.Drawing.Size(609, 43);
            this.colorSettingsControl8.TabIndex = 0;
            this.colorSettingsControl8.ColorPicked += new System.EventHandler(this.ColorSettingsControl_ColorPicked);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(8, 490);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(15);
            this.panel3.Size = new System.Drawing.Size(613, 15);
            this.panel3.TabIndex = 5;
            // 
            // _workspaceColors
            // 
            this._workspaceColors.Controls.Add(this.colorSettingsControl4);
            this._workspaceColors.Controls.Add(this.colorSettingsControl3);
            this._workspaceColors.Controls.Add(this.colorSettingsControl2);
            this._workspaceColors.Controls.Add(this.colorSettingsControl1);
            this._workspaceColors.Dock = System.Windows.Forms.DockStyle.Top;
            this._workspaceColors.Location = new System.Drawing.Point(8, 311);
            this._workspaceColors.Margin = new System.Windows.Forms.Padding(2);
            this._workspaceColors.Name = "_workspaceColors";
            this._workspaceColors.Padding = new System.Windows.Forms.Padding(2);
            this._workspaceColors.Size = new System.Drawing.Size(613, 179);
            this._workspaceColors.TabIndex = 1;
            this._workspaceColors.TabStop = false;
            this._workspaceColors.Text = "Workspace name colors";
            // 
            // colorSettingsControl4
            // 
            this.colorSettingsControl4.AutoSize = true;
            this.colorSettingsControl4.ColorHex = "#B93139";
            this.colorSettingsControl4.ColorSetting = KomoSwitch.Models.Settings.EColorSetting.WorkspaceError;
            this.colorSettingsControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.colorSettingsControl4.Location = new System.Drawing.Point(2, 136);
            this.colorSettingsControl4.Margin = new System.Windows.Forms.Padding(0);
            this.colorSettingsControl4.Name = "colorSettingsControl4";
            this.colorSettingsControl4.Padding = new System.Windows.Forms.Padding(15, 5, 12, 5);
            this.colorSettingsControl4.SettingName = "Error";
            this.colorSettingsControl4.Size = new System.Drawing.Size(609, 38);
            this.colorSettingsControl4.TabIndex = 3;
            this.colorSettingsControl4.ColorPicked += new System.EventHandler(this.ColorSettingsControl_ColorPicked);
            // 
            // colorSettingsControl3
            // 
            this.colorSettingsControl3.AutoSize = true;
            this.colorSettingsControl3.ColorHex = "#696969";
            this.colorSettingsControl3.ColorSetting = KomoSwitch.Models.Settings.EColorSetting.WorkspaceWaiting;
            this.colorSettingsControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.colorSettingsControl3.Location = new System.Drawing.Point(2, 98);
            this.colorSettingsControl3.Margin = new System.Windows.Forms.Padding(0);
            this.colorSettingsControl3.Name = "colorSettingsControl3";
            this.colorSettingsControl3.Padding = new System.Windows.Forms.Padding(15, 5, 12, 5);
            this.colorSettingsControl3.SettingName = "Waiting";
            this.colorSettingsControl3.Size = new System.Drawing.Size(609, 38);
            this.colorSettingsControl3.TabIndex = 2;
            this.colorSettingsControl3.ColorPicked += new System.EventHandler(this.ColorSettingsControl_ColorPicked);
            // 
            // colorSettingsControl2
            // 
            this.colorSettingsControl2.AutoSize = true;
            this.colorSettingsControl2.ColorHex = "#3FC611";
            this.colorSettingsControl2.ColorSetting = KomoSwitch.Models.Settings.EColorSetting.WorkspaceActive;
            this.colorSettingsControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.colorSettingsControl2.Location = new System.Drawing.Point(2, 60);
            this.colorSettingsControl2.Margin = new System.Windows.Forms.Padding(0);
            this.colorSettingsControl2.Name = "colorSettingsControl2";
            this.colorSettingsControl2.Padding = new System.Windows.Forms.Padding(15, 5, 12, 5);
            this.colorSettingsControl2.SettingName = "Active";
            this.colorSettingsControl2.Size = new System.Drawing.Size(609, 38);
            this.colorSettingsControl2.TabIndex = 1;
            this.colorSettingsControl2.ColorPicked += new System.EventHandler(this.ColorSettingsControl_ColorPicked);
            // 
            // colorSettingsControl1
            // 
            this.colorSettingsControl1.AutoSize = true;
            this.colorSettingsControl1.ColorSetting = KomoSwitch.Models.Settings.EColorSetting.WorkspaceDefault;
            this.colorSettingsControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.colorSettingsControl1.Location = new System.Drawing.Point(2, 17);
            this.colorSettingsControl1.Margin = new System.Windows.Forms.Padding(0);
            this.colorSettingsControl1.Name = "colorSettingsControl1";
            this.colorSettingsControl1.Padding = new System.Windows.Forms.Padding(15, 10, 12, 5);
            this.colorSettingsControl1.Size = new System.Drawing.Size(609, 43);
            this.colorSettingsControl1.TabIndex = 0;
            this.colorSettingsControl1.ColorPicked += new System.EventHandler(this.ColorSettingsControl_ColorPicked);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(8, 296);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(613, 15);
            this.panel2.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._workspaceWidth);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this._syncWithTheme);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this._workspaceGap);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this._appMinWidth);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this._selectFontButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this._statusLineLocationList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(613, 291);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // _workspaceWidth
            // 
            this._workspaceWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._workspaceWidth.Location = new System.Drawing.Point(489, 149);
            this._workspaceWidth.Margin = new System.Windows.Forms.Padding(2);
            this._workspaceWidth.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this._workspaceWidth.Name = "_workspaceWidth";
            this._workspaceWidth.Size = new System.Drawing.Size(108, 23);
            this._workspaceWidth.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(15, 119);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(294, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Restart is required for changes to take affect";
            // 
            // _syncWithTheme
            // 
            this._syncWithTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._syncWithTheme.AutoSize = true;
            this._syncWithTheme.Location = new System.Drawing.Point(488, 252);
            this._syncWithTheme.Margin = new System.Windows.Forms.Padding(2);
            this._syncWithTheme.Name = "_syncWithTheme";
            this._syncWithTheme.Size = new System.Drawing.Size(18, 17);
            this._syncWithTheme.TabIndex = 13;
            this._syncWithTheme.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 253);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sync primary colors with Windows theme";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(488, 219);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(15, 219);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Hide empty workspaces";
            // 
            // _workspaceGap
            // 
            this._workspaceGap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._workspaceGap.Location = new System.Drawing.Point(489, 183);
            this._workspaceGap.Margin = new System.Windows.Forms.Padding(2);
            this._workspaceGap.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this._workspaceGap.Name = "_workspaceGap";
            this._workspaceGap.Size = new System.Drawing.Size(108, 23);
            this._workspaceGap.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 186);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Workspace gap";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Workspace width";
            // 
            // _appMinWidth
            // 
            this._appMinWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._appMinWidth.Location = new System.Drawing.Point(489, 98);
            this._appMinWidth.Margin = new System.Windows.Forms.Padding(2);
            this._appMinWidth.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this._appMinWidth.Name = "_appMinWidth";
            this._appMinWidth.Size = new System.Drawing.Size(108, 23);
            this._appMinWidth.TabIndex = 5;
            this._appMinWidth.ValueChanged += new System.EventHandler(this.AppMinWidth_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "App min width";
            // 
            // _selectFontButton
            // 
            this._selectFontButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._selectFontButton.Location = new System.Drawing.Point(489, 58);
            this._selectFontButton.Margin = new System.Windows.Forms.Padding(2);
            this._selectFontButton.Name = "_selectFontButton";
            this._selectFontButton.Size = new System.Drawing.Size(109, 26);
            this._selectFontButton.TabIndex = 3;
            this._selectFontButton.Text = "Pick";
            this._selectFontButton.UseVisualStyleBackColor = true;
            this._selectFontButton.Click += new System.EventHandler(this.SelectFontButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Font";
            // 
            // _statusLineLocationList
            // 
            this._statusLineLocationList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._statusLineLocationList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._statusLineLocationList.FormattingEnabled = true;
            this._statusLineLocationList.Location = new System.Drawing.Point(489, 30);
            this._statusLineLocationList.Margin = new System.Windows.Forms.Padding(2);
            this._statusLineLocationList.Name = "_statusLineLocationList";
            this._statusLineLocationList.Size = new System.Drawing.Size(109, 25);
            this._statusLineLocationList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status line location";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(655, 471);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KomoSwitch Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this._statusLineColors.ResumeLayout(false);
            this._statusLineColors.PerformLayout();
            this._workspaceBackgroundColors.ResumeLayout(false);
            this._workspaceBackgroundColors.PerformLayout();
            this._workspaceColors.ResumeLayout(false);
            this._workspaceColors.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._workspaceWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._workspaceGap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._appMinWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private KomoSwitch.Controls.ColorSettingsControl colorSettingsControl2;
        private KomoSwitch.Controls.ColorSettingsControl colorSettingsControl3;
        private KomoSwitch.Controls.ColorSettingsControl colorSettingsControl4;

        private System.Windows.Forms.NumericUpDown _workspaceWidth;

        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Panel panel1;

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown _workspaceGap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown _appMinWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button _selectFontButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox _statusLineLocationList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox _workspaceColors;
        private KomoSwitch.Controls.ColorSettingsControl colorSettingsControl1;
        private System.Windows.Forms.GroupBox _workspaceBackgroundColors;
        private KomoSwitch.Controls.ColorSettingsControl colorSettingsControl5;
        private KomoSwitch.Controls.ColorSettingsControl colorSettingsControl6;
        private KomoSwitch.Controls.ColorSettingsControl colorSettingsControl7;
        private KomoSwitch.Controls.ColorSettingsControl colorSettingsControl8;
        private System.Windows.Forms.CheckBox _syncWithTheme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox _statusLineColors;
        private KomoSwitch.Controls.ColorSettingsControl colorSettingsControl10;
        private KomoSwitch.Controls.ColorSettingsControl colorSettingsControl11;
        private KomoSwitch.Controls.ColorSettingsControl colorSettingsControl12;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}