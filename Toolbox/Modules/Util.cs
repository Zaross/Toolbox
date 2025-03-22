using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox.Modules
{
    public class Util
    {
        public string[] ConvertHex(string hex)
        {
            if (hex.Length % 2 != 0)
            {
                throw new ArgumentException("Invalid hex string length.");
            }
            byte[] bytes = new byte[hex.Length / 2];
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return bytes.Select(b => b.ToString()).ToArray();
        }
    }
}
