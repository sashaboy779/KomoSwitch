using System;
using System.Windows.Forms;

namespace KomoSwitch.Controls
{
    public partial class SettingsForm : Form
    {
        private readonly WorkspacesContainer _container;
        private readonly FontDialog _fontDialog;
        
        public SettingsForm(WorkspacesContainer container)
        {
            InitializeComponent();
            _container = container;
            _fontDialog = new FontDialog();

            var workspace = _container.Controls[0] as WorkspaceControl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control control in _container.Controls)
            {
                if (control is WorkspaceControl workspaceControl)
                {
                    var newPadding = workspaceControl.Padding.Right + 10;
                    workspaceControl.Padding = new Padding(0, 0, newPadding, 0);
                }
            }
            
            _container.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control control in _container.Controls)
            {
                if (control is WorkspaceControl workspaceControl)
                {
                    var newPadding = workspaceControl.Padding.Right - 10;
                    workspaceControl.Padding = new Padding(0, 0, newPadding, 0);
                }
            }
            
            _container.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control control in _container.Controls)
            {
                if (control is WorkspaceControl workspaceControl)
                {
                    var currentDock = workspaceControl.StatusLine.Dock;
                    
                    workspaceControl.StatusLine.Dock = currentDock == DockStyle.Top 
                        ? DockStyle.Bottom 
                        : DockStyle.Top;
                }
            }
            
            _container.Invalidate();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (Control control in _container.Controls)
            {
                if (control is WorkspaceControl workspaceControl)
                {
                    var currentDock = workspaceControl.StatusLine.Dock;
                    
                    workspaceControl.StatusLine.Dock = currentDock == DockStyle.Top 
                        ? DockStyle.Bottom 
                        : DockStyle.Top;
                }
            }
            
            _container.Invalidate();
        }

        private void tb_workspace_gap_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            var newPadding = int.Parse(textBox.Text);

            foreach (Control control in _container.Controls)
            {
                if (control is WorkspaceControl workspaceControl)
                {
                    workspaceControl.Padding = new Padding(0, 0, newPadding, 0);
                }
            }
            
            _container.Invalidate();
        }

        private void tb_workspace_gap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void nud_workspace_gap_ValueChanged(object sender, EventArgs e)
        {
            var numericUpDown = sender as NumericUpDown;
            var newPadding = int.Parse(numericUpDown.Text);

            foreach (Control control in _container.Controls)
            {
                if (control is WorkspaceControl workspaceControl)
                {
                    workspaceControl.Padding = new Padding(0, 0, newPadding, 0);
                }
            }
            
            _container.Invalidate();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (_fontDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (Control control in _container.Controls)
                {
                    if (control is WorkspaceControl workspaceControl)
                    {
                        workspaceControl.WorkspaceNameText.Font = _fontDialog.Font;
                    }
                }
            }
            
            _container.Invalidate();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            dialog.FullOpen = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}