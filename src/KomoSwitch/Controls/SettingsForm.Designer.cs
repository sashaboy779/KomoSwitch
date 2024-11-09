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
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.colorSettingsControl9 = new KomoSwitch.Controls.ColorSettingsControl();
            this.colorSettingsControl10 = new KomoSwitch.Controls.ColorSettingsControl();
            this.colorSettingsControl11 = new KomoSwitch.Controls.ColorSettingsControl();
            this.colorSettingsControl12 = new KomoSwitch.Controls.ColorSettingsControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.colorSettingsControl5 = new KomoSwitch.Controls.ColorSettingsControl();
            this.colorSettingsControl6 = new KomoSwitch.Controls.ColorSettingsControl();
            this.colorSettingsControl7 = new KomoSwitch.Controls.ColorSettingsControl();
            this.colorSettingsControl8 = new KomoSwitch.Controls.ColorSettingsControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.colorSettingsControl4 = new KomoSwitch.Controls.ColorSettingsControl();
            this.colorSettingsControl3 = new KomoSwitch.Controls.ColorSettingsControl();
            this.colorSettingsControl2 = new KomoSwitch.Controls.ColorSettingsControl();
            this.colorSettingsControl1 = new KomoSwitch.Controls.ColorSettingsControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._appMinWidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this._statusLineLocationList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._appMinWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 888);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 1852);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 62);
            this.button2.TabIndex = 6;
            this.button2.Text = "Open Json";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.colorSettingsControl9);
            this.groupBox4.Controls.Add(this.colorSettingsControl10);
            this.groupBox4.Controls.Add(this.colorSettingsControl11);
            this.groupBox4.Controls.Add(this.colorSettingsControl12);
            this.groupBox4.Location = new System.Drawing.Point(12, 1435);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1130, 387);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Status line";
            // 
            // colorSettingsControl9
            // 
            this.colorSettingsControl9.Location = new System.Drawing.Point(28, 275);
            this.colorSettingsControl9.Name = "colorSettingsControl9";
            this.colorSettingsControl9.Size = new System.Drawing.Size(1048, 76);
            this.colorSettingsControl9.TabIndex = 3;
            // 
            // colorSettingsControl10
            // 
            this.colorSettingsControl10.Location = new System.Drawing.Point(28, 202);
            this.colorSettingsControl10.Name = "colorSettingsControl10";
            this.colorSettingsControl10.Size = new System.Drawing.Size(1048, 76);
            this.colorSettingsControl10.TabIndex = 2;
            // 
            // colorSettingsControl11
            // 
            this.colorSettingsControl11.Location = new System.Drawing.Point(28, 132);
            this.colorSettingsControl11.Name = "colorSettingsControl11";
            this.colorSettingsControl11.Size = new System.Drawing.Size(1048, 76);
            this.colorSettingsControl11.TabIndex = 1;
            // 
            // colorSettingsControl12
            // 
            this.colorSettingsControl12.Location = new System.Drawing.Point(28, 50);
            this.colorSettingsControl12.Name = "colorSettingsControl12";
            this.colorSettingsControl12.Size = new System.Drawing.Size(1048, 76);
            this.colorSettingsControl12.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.colorSettingsControl5);
            this.groupBox3.Controls.Add(this.colorSettingsControl6);
            this.groupBox3.Controls.Add(this.colorSettingsControl7);
            this.groupBox3.Controls.Add(this.colorSettingsControl8);
            this.groupBox3.Location = new System.Drawing.Point(14, 1031);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1130, 387);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Workspace background";
            // 
            // colorSettingsControl5
            // 
            this.colorSettingsControl5.Location = new System.Drawing.Point(28, 275);
            this.colorSettingsControl5.Name = "colorSettingsControl5";
            this.colorSettingsControl5.Size = new System.Drawing.Size(1048, 76);
            this.colorSettingsControl5.TabIndex = 3;
            // 
            // colorSettingsControl6
            // 
            this.colorSettingsControl6.Location = new System.Drawing.Point(28, 202);
            this.colorSettingsControl6.Name = "colorSettingsControl6";
            this.colorSettingsControl6.Size = new System.Drawing.Size(1048, 76);
            this.colorSettingsControl6.TabIndex = 2;
            // 
            // colorSettingsControl7
            // 
            this.colorSettingsControl7.Location = new System.Drawing.Point(28, 132);
            this.colorSettingsControl7.Name = "colorSettingsControl7";
            this.colorSettingsControl7.Size = new System.Drawing.Size(1048, 76);
            this.colorSettingsControl7.TabIndex = 1;
            // 
            // colorSettingsControl8
            // 
            this.colorSettingsControl8.Location = new System.Drawing.Point(28, 50);
            this.colorSettingsControl8.Name = "colorSettingsControl8";
            this.colorSettingsControl8.Size = new System.Drawing.Size(1048, 76);
            this.colorSettingsControl8.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.colorSettingsControl4);
            this.groupBox2.Controls.Add(this.colorSettingsControl3);
            this.groupBox2.Controls.Add(this.colorSettingsControl2);
            this.groupBox2.Controls.Add(this.colorSettingsControl1);
            this.groupBox2.Location = new System.Drawing.Point(13, 620);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1130, 387);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Workspace name";
            // 
            // colorSettingsControl4
            // 
            this.colorSettingsControl4.Location = new System.Drawing.Point(28, 275);
            this.colorSettingsControl4.Name = "colorSettingsControl4";
            this.colorSettingsControl4.Size = new System.Drawing.Size(1048, 76);
            this.colorSettingsControl4.TabIndex = 3;
            // 
            // colorSettingsControl3
            // 
            this.colorSettingsControl3.Location = new System.Drawing.Point(28, 202);
            this.colorSettingsControl3.Name = "colorSettingsControl3";
            this.colorSettingsControl3.Size = new System.Drawing.Size(1048, 76);
            this.colorSettingsControl3.TabIndex = 2;
            // 
            // colorSettingsControl2
            // 
            this.colorSettingsControl2.Location = new System.Drawing.Point(28, 132);
            this.colorSettingsControl2.Name = "colorSettingsControl2";
            this.colorSettingsControl2.Size = new System.Drawing.Size(1048, 76);
            this.colorSettingsControl2.TabIndex = 1;
            // 
            // colorSettingsControl1
            // 
            this.colorSettingsControl1.Location = new System.Drawing.Point(28, 50);
            this.colorSettingsControl1.Name = "colorSettingsControl1";
            this.colorSettingsControl1.Size = new System.Drawing.Size(1048, 76);
            this.colorSettingsControl1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this._appMinWidth);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this._statusLineLocationList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1131, 587);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(22, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(589, 32);
            this.label8.TabIndex = 14;
            this.label8.Text = "Restart is required for changes to take affect";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(963, 506);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(34, 33);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 506);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(528, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sync primary colors with Windows theme";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(963, 445);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(34, 33);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(314, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Hide empty workspaces";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(865, 362);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(200, 38);
            this.numericUpDown3.TabIndex = 9;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(865, 302);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(200, 38);
            this.numericUpDown2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Workspace gap";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Workspace width";
            // 
            // _appMinWidth
            // 
            this._appMinWidth.Location = new System.Drawing.Point(865, 206);
            this._appMinWidth.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            this._appMinWidth.Name = "_appMinWidth";
            this._appMinWidth.Size = new System.Drawing.Size(200, 38);
            this._appMinWidth.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "App min width";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(894, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 61);
            this.button1.TabIndex = 3;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Font";
            // 
            // _statusLineLocationList
            // 
            this._statusLineLocationList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._statusLineLocationList.FormattingEnabled = true;
            this._statusLineLocationList.Location = new System.Drawing.Point(851, 58);
            this._statusLineLocationList.Name = "_statusLineLocationList";
            this._statusLineLocationList.Size = new System.Drawing.Size(214, 39);
            this._statusLineLocationList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status line location";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1209, 918);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.ShowIcon = false;
            this.Text = "KomoSwitch Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._appMinWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Panel panel1;

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown _appMinWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox _statusLineLocationList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private ColorSettingsControl colorSettingsControl1;
        private System.Windows.Forms.GroupBox groupBox3;
        private ColorSettingsControl colorSettingsControl5;
        private ColorSettingsControl colorSettingsControl6;
        private ColorSettingsControl colorSettingsControl7;
        private ColorSettingsControl colorSettingsControl8;
        private ColorSettingsControl colorSettingsControl4;
        private ColorSettingsControl colorSettingsControl3;
        private ColorSettingsControl colorSettingsControl2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private ColorSettingsControl colorSettingsControl9;
        private ColorSettingsControl colorSettingsControl10;
        private ColorSettingsControl colorSettingsControl11;
        private ColorSettingsControl colorSettingsControl12;
        private System.Windows.Forms.Button button2;
    }
}