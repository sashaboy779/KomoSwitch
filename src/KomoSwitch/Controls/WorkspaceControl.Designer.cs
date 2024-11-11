using System.ComponentModel;

namespace KomoSwitch.Controls
{
    partial class WorkspaceControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._workspaceBackground = new System.Windows.Forms.Panel();
            this._statusLine = new System.Windows.Forms.Panel();
            this._workspaceName = new System.Windows.Forms.Label();
            this._workspaceBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // _workspaceBackground
            // 
            this._workspaceBackground.AutoSize = true;
            this._workspaceBackground.BackColor = System.Drawing.Color.Transparent;
            this._workspaceBackground.Controls.Add(this._statusLine);
            this._workspaceBackground.Controls.Add(this._workspaceName);
            this._workspaceBackground.Dock = System.Windows.Forms.DockStyle.Left;
            this._workspaceBackground.Location = new System.Drawing.Point(0, 0);
            this._workspaceBackground.Margin = new System.Windows.Forms.Padding(0);
            this._workspaceBackground.Name = "_workspaceBackground";
            this._workspaceBackground.Size = new System.Drawing.Size(103, 100);
            this._workspaceBackground.TabIndex = 0;
            // 
            // _statusLine
            // 
            this._statusLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this._statusLine.Dock = System.Windows.Forms.DockStyle.Top;
            this._statusLine.Location = new System.Drawing.Point(0, 0);
            this._statusLine.Name = "_statusLine";
            this._statusLine.Size = new System.Drawing.Size(103, 6);
            this._statusLine.TabIndex = 1;
            // 
            // _workspaceName
            // 
            this._workspaceName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._workspaceName.BackColor = System.Drawing.Color.Transparent;
            this._workspaceName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._workspaceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._workspaceName.ForeColor = System.Drawing.Color.White;
            this._workspaceName.Location = new System.Drawing.Point(0, 0);
            this._workspaceName.MinimumSize = new System.Drawing.Size(50, 100);
            this._workspaceName.Name = "_workspaceName";
            this._workspaceName.Size = new System.Drawing.Size(100, 100);
            this._workspaceName.TabIndex = 1;
            this._workspaceName.Text = "1";
            this._workspaceName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._workspaceName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_name_MouseClick);
            this._workspaceName.MouseEnter += new System.EventHandler(this.lbl_name_MouseEnter);
            this._workspaceName.MouseLeave += new System.EventHandler(this.lbl_name_MouseLeave);
            // 
            // WorkspaceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._workspaceBackground);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "WorkspaceControl";
            this.Size = new System.Drawing.Size(300, 100);
            this._workspaceBackground.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label _workspaceName;

        private System.Windows.Forms.Panel _workspaceBackground;

        #endregion

        private System.Windows.Forms.Panel _statusLine;
    }
}