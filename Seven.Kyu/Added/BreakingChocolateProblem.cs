using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven.Kyu.Added
{
    public class BreakingChocolateProblem
    {
        public static int BreakChocolate(int n, int m) => n == 0 || m == 0 ? 0 : n * m - 1;
    }
}
