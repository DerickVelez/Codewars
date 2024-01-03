using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven.Kyu
{
    public class Is_this_a_triangle
    {
        public static bool IsTriangle(int a, int b, int c)
        {
            var maxnum = new[] { a, b, c }.Max();
            var min1 = new[] { a, b, c }.Min();
            var min2 = new[] { a, b, c }.Sum() - maxnum - min1;

            if (a == b && a == c)
            { return true; }
            if (a < 0 || b < 0 || c < 0)
            { return false; }
            if (min1 + min2 <= maxnum)
            { return false; }
            else
            { return true; }
        }
    }
}
