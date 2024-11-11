namespace KomoSwitch.Controls
{
    partial class ColorSettingsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._settingName = new System.Windows.Forms.Label();
            this._pickColorButton = new System.Windows.Forms.Button();
            this._hexColorBackground = new System.Windows.Forms.Panel();
            this._hexColorText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this._hexColorBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // _settingName
            // 
            this._settingName.AutoSize = true;
            this._settingName.Location = new System.Drawing.Point(0, 10);
            this._settingName.Margin = new System.Windows.Forms.Padding(0);
            this._settingName.Name = "_settingName";
            this._settingName.Size = new System.Drawing.Size(106, 32);
            this._settingName.TabIndex = 0;
            this._settingName.Text = "Default";
            // 
            // _pickColorButton
            // 
            this._pickColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._pickColorButton.Location = new System.Drawing.Point(535, 3);
            this._pickColorButton.Name = "_pickColorButton";
            this._pickColorButton.Size = new System.Drawing.Size(155, 50);
            this._pickColorButton.TabIndex = 2;
            this._pickColorButton.Text = "Pick";
            this._pickColorButton.UseVisualStyleBackColor = true;
            this._pickColorButton.Click += new System.EventHandler(this.PickColorButton_Click);
            // 
            // _hexColorBackground
            // 
            this._hexColorBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._hexColorBackground.Controls.Add(this._hexColorText);
            this._hexColorBackground.Location = new System.Drawing.Point(360, 3);
            this._hexColorBackground.Name = "_hexColorBackground";
            this._hexColorBackground.Size = new System.Drawing.Size(169, 50);
            this._hexColorBackground.TabIndex = 3;
            // 
            // _hexColorText
            // 
            this._hexColorText.Dock = System.Windows.Forms.DockStyle.Fill;
            this._hexColorText.Location = new System.Drawing.Point(0, 0);
            this._hexColorText.Name = "_hexColorText";
            this._hexColorText.Size = new System.Drawing.Size(169, 50);
            this._hexColorText.TabIndex = 0;
            this._hexColorText.Text = "#123456";
            this._hexColorText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "Reset color to default";
            this.button1.AccessibleName = "Reset";
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(696, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "↻";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.RestButton_Click);
            // 
            // ColorSettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.button1);
            this.Controls.Add(this._hexColorBackground);
            this.Controls.Add(this._pickColorButton);
            this.Controls.Add(this._settingName);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ColorSettingsControl";
            this.Size = new System.Drawing.Size(745, 56);
            this._hexColorBackground.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label _hexColorText;

        private System.Windows.Forms.Panel _hexColorBackground;

        #endregion

        private System.Windows.Forms.Label _settingName;
        private System.Windows.Forms.Button _pickColorButton;
    }
}
