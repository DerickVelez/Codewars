using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven.Kyu
{
    public class CircleAreaInsideSquare
    {
        public static double SquareAreaToCircle(double size)
        {
            var radius = Math.Sqrt(size) / 2;
            var AreaofCircle = Math.PI * (radius * radius);
            return Math.Round(AreaofCircle, 8);
        }
    }
}
