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
            this.workspaceBackground = new System.Windows.Forms.Panel();
            this._statusLine = new System.Windows.Forms.Panel();
            this._workspaceName = new System.Windows.Forms.Label();
            this.workspaceBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // workspaceBackground
            // 
            this.workspaceBackground.AutoSize = true;
            this.workspaceBackground.BackColor = System.Drawing.Color.Transparent;
            this.workspaceBackground.Controls.Add(this._statusLine);
            this.workspaceBackground.Controls.Add(this._workspaceName);
            this.workspaceBackground.Dock = System.Windows.Forms.DockStyle.Left;
            this.workspaceBackground.Location = new System.Drawing.Point(0, 0);
            this.workspaceBackground.Margin = new System.Windows.Forms.Padding(0);
            this.workspaceBackground.Name = "workspaceBackground";
            this.workspaceBackground.Size = new System.Drawing.Size(53, 100);
            this.workspaceBackground.TabIndex = 0;
            // 
            // _statusLine
            // 
            this._statusLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this._statusLine.Dock = System.Windows.Forms.DockStyle.Top;
            this._statusLine.Location = new System.Drawing.Point(0, 0);
            this._statusLine.Name = "_statusLine";
            this._statusLine.Size = new System.Drawing.Size(53, 6);
            this._statusLine.TabIndex = 1;
            // 
            // _workspaceName
            // 
            this._workspaceName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._workspaceName.AutoSize = true;
            this._workspaceName.BackColor = System.Drawing.Color.Transparent;
            this._workspaceName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._workspaceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._workspaceName.ForeColor = System.Drawing.Color.White;
            this._workspaceName.Location = new System.Drawing.Point(0, 0);
            this._workspaceName.MinimumSize = new System.Drawing.Size(50, 100);
            this._workspaceName.Name = "_workspaceName";
            this._workspaceName.Size = new System.Drawing.Size(50, 100);
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
            this.Controls.Add(this.workspaceBackground);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "WorkspaceControl";
            this.Size = new System.Drawing.Size(731, 100);
            this.workspaceBackground.ResumeLayout(false);
            this.workspaceBackground.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label _workspaceName;

        private System.Windows.Forms.Panel workspaceBackground;

        #endregion

        private System.Windows.Forms.Panel _statusLine;
    }
}