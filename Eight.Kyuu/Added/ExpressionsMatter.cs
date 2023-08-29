using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu.Added
{
    public class ExpressionsMatter
    {
        public static int ExpressionsMatterExecution(int a, int b, int c)
        {
            int num1 = a * (b + c);
            int num2 = a * b * c;
            int num3 = a + b * c;
            int num4 = (a + b) * c;
            int num5 = a + b + c;

            int num6 = Math.Max(num1, num2);
            int num7 = Math.Max(num3, num4);
            int num8 = Math.Max(num6, num7);

            return Math.Max(num5, num8);
        }
    }
}
