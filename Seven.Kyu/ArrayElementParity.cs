using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven.Kyu
{
    public class ArrayElementParity
    {
        public static int Solve(int[] arr) => arr.Distinct().ToArray().Sum();
    }

}
