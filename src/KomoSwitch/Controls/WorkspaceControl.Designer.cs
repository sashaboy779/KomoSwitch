using System.ComponentModel;

namespace KomoSwitch
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
            this.pnl_background = new System.Windows.Forms.Panel();
            this.pnl_line = new System.Windows.Forms.Panel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pnl_background.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_background
            // 
            this.pnl_background.AutoSize = true;
            this.pnl_background.BackColor = System.Drawing.Color.Transparent;
            this.pnl_background.Controls.Add(this.pnl_line);
            this.pnl_background.Controls.Add(this.lbl_name);
            this.pnl_background.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_background.Location = new System.Drawing.Point(0, 0);
            this.pnl_background.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_background.Name = "pnl_background";
            this.pnl_background.Size = new System.Drawing.Size(53, 100);
            this.pnl_background.TabIndex = 0;
            // 
            // pnl_line
            // 
            this.pnl_line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.pnl_line.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_line.Location = new System.Drawing.Point(0, 94);
            this.pnl_line.Name = "pnl_line";
            this.pnl_line.Size = new System.Drawing.Size(53, 6);
            this.pnl_line.TabIndex = 1;
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(0, 0);
            this.lbl_name.MinimumSize = new System.Drawing.Size(50, 100);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(50, 100);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "1";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_name.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_name_MouseClick);
            this.lbl_name.MouseEnter += new System.EventHandler(this.lbl_name_MouseEnter);
            this.lbl_name.MouseLeave += new System.EventHandler(this.lbl_name_MouseLeave);
            // 
            // WorkspaceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_background);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "WorkspaceControl";
            this.Size = new System.Drawing.Size(731, 100);
            this.pnl_background.ResumeLayout(false);
            this.pnl_background.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lbl_name;

        private System.Windows.Forms.Panel pnl_background;

        #endregion

        private System.Windows.Forms.Panel pnl_line;
    }
}