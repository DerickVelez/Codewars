using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu.Added
{
    public class DivisiblebyNB
    {
        public static bool IsDivisible(int n, int x, int y) => n % x == 0 && n % y == 0 ? true : false;

    }
}
