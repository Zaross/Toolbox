using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox.helper
{
    public class Converter_hex
    {

        /// <summary>
        /// Converts a hexadecimal color code to a <see cref="Color"/> object.
        /// </summary>
        /// <param name="hexColor">The hexadecimal color code. It can be in the format of 6 or 8 characters, with or without a leading '#'.</param>
        /// <returns>A <see cref="Color"/> object that represents the color specified by the hexadecimal code.</returns>
        /// <exception cref="ArgumentException">Thrown when the hexadecimal color code is not 6 or 8 characters long.</exception>
        public static Color ConvertHexToColor(string hexColor)
        {
            if (hexColor.StartsWith("#"))
            {
                hexColor = hexColor.Substring(1);
            }

            if (hexColor.Length != 6 && hexColor.Length != 8)
            {
                throw new ArgumentException("Ungültiger Hex-Farbcode. Der Hex-Code muss 6 oder 8 Zeichen lang sein.");
            }

            if (hexColor.Length == 6)
            {
                hexColor = "FF" + hexColor;
            }

            int alpha = Convert.ToInt32(hexColor.Substring(0, 2), 16);
            int red = Convert.ToInt32(hexColor.Substring(2, 2), 16);
            int green = Convert.ToInt32(hexColor.Substring(4, 2), 16);
            int blue = Convert.ToInt32(hexColor.Substring(6, 2), 16);
            return Color.FromArgb(alpha, red, green, blue);
        }
    }
}
