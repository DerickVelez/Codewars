using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six_Kyu
{
    public class TriangleNumberCheck
    {
        public static bool isTriangleNumber(long number)
        {


            var n = Math.Sqrt(number / 0.5);
            var reverseN = (int)Math.Floor(n);

            int result = ((reverseN + 1) * reverseN) / 2;


            if (result == number)
            { return true; }
            return false;
        }
    }
}
