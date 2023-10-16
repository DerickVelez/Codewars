using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven.Kyu
{
    public class AreaOfaCircle
    {
        public static double CalculateAreaOfCircle(double radius)
        {
            if (radius <= 0)
                throw new System.ArgumentException("");
            else
                return 3.141592653589793238 * (radius * radius);
        }
    }
}
