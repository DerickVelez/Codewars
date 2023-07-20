using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu
{
    public class SumOfPositive
    {
        public static int PositiveSum(int[] arr)
        {
            return arr.Where(n => n > 0).Sum();
        }
    }
}
