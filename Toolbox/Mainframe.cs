using static Toolbox.helper.Converter_hex;
using static Toolbox.Masks.Scanner_ip;

namespace Toolbox
{
    public partial class Mainframe : Form
    {
        public Mainframe()
        {
            InitializeComponent();
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {

        }

        private void Button_Minimize_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlToolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {

        }

        private void Button_Scanner_IP_Click(object sender, EventArgs e)
        {
            Masks.Scanner_ip Scanner_IP_Mask = new Masks.Scanner_ip();
            Scanner_IP_Mask.Show();
        }
    }
}
