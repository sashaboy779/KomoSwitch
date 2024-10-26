using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KomoSwitch
{
    public partial class UserControl1: UserControl
    {
        public UserControl1(CSDeskBand.CSDeskBandWin w)
        {
            InitializeComponent();
        }

        protected override bool ProcessKeyPreview(ref Message m)
        {
            if ((Keys)m.WParam == Keys.Tab)
            {
                var selected = SelectNextControl(ActiveControl, true, true, true, true);
                return true;
            }

            return base.ProcessKeyPreview(ref m);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SwitchWorkspace(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SwitchWorkspace(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SwitchWorkspace(2);
        }
        
        private void SwitchWorkspace(int index) {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "komorebic.exe";
            startInfo.Arguments = $"focus-workspace {index}";
            process.StartInfo = startInfo;
            process.Start();
        }
    }
}
