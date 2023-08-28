using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Five_Kyu_Kata
{
    public class RGBtoHexConversion
    {
        public static string Rgb(int r, int g, int b)
        {
            var red = r > 255 ? 255 : (r < 0 ? 0 : r);
            var green = g > 255 ? 255 : (g < 0 ? 0 : g);
            var blue = b > 255 ? 255 : (b < 0 ? 0 : b);

            return red.ToString("X2") + green.ToString("X2") + blue.ToString("X2");
        }
    }
}
