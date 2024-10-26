using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KomoSwitch
{
    [ComVisible(true)]
    [Guid("6F42B9CA-592E-4838-95CA-85CD46C57982")]
    [CSDeskBand.CSDeskBandRegistration(Name = "KomoSwitch", ShowDeskBand = false)]
    public class Deskband : CSDeskBand.CSDeskBandWin
    {
        private static Control _control;

        public Deskband()
        {
            Options.MinHorizontalSize = new Size(300, 30);
            _control = new UserControl1(this);
        }

        protected override Control Control => _control;
    }
}
