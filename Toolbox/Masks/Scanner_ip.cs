using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Toolbox.Modules.Scanner_ip;

namespace Toolbox.Masks
{
    public partial class Scanner_ip : Form
    {
        public Scanner_ip()
        {
            InitializeComponent();
        }

        private void Image_Button_Scanner_IP_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void Button_Start_IP_Scan_Click(object sender, EventArgs e)
        {
            string ipAddress = IPBox.Text;
            string ip1;
            string ip2;
            if (string.IsNullOrEmpty(ipAddress))
            {
                MessageBox.Show("Bitte geben Sie eine IP-Adresse ein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ip1 = ipAddress;
            ip2 = ipAddress;
            if (ipAddress.Contains("-"))
            {
                string[] ips = ipAddress.Split('-');
                ip1 = ips[0];
                if (ips[1].Contains("."))
                {
                    ip2 = ips[1];
                }
                else
                {
                    string[] ip1Parts = ip1.Split('.');
                    ip2 = $"{ip1Parts[0]}.{ip1Parts[1]}.{ip1Parts[2]}.{ips[1]}";
                }
            }
            else if (ipAddress.Contains(","))
            {
                string[] ips = ipAddress.Split(',');
                ip1 = ips[0];
                ip2 = ips[1];
            }

            var scanner = new Toolbox.Modules.Scanner_ip(guna2DataGridView1);
            await scanner.ScanNetworkRangeAsync(ip1, ip2);
        }
    }
}
