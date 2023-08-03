using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven.Kyu
{
    public class TwoNumbersArePositive
    {
        public static bool TwoArePositive(int a, int b, int c)
        {
            int counter = 0;

            if (a > 0)
            { counter++; }
            if (b > 0)
            { counter++; }
            if (c > 0)
            { counter++; }

            if (counter == 2)
                return true;
            else
                return false;

        }
    }
}
