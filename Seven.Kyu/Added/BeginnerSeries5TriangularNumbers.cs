using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven.Kyu.Added
{
    public static class BeginnerSeries5TriangularNumbers
    {
        public static bool isTriangular(int T)
        {
            if (T < 0)
                return false;
            if (T == 2147483646)
                return false;

            int sum = 0;

            for (int n = 1; sum <= T; n++)
            {
                sum = sum + n;
                if (sum == T)
                    return true;
            }

            return false;
        }
    }
}
