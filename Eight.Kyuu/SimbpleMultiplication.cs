using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu
{
    public class SimbpleMultiplication
    {
        public static int Multiply(int x) => x % 2 == 0 ? x * 8 : x * 9;
    }
}
