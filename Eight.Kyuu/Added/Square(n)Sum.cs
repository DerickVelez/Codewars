using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu
{
    public class Square_n_Sum
    {
        public static int SquareSum(int[] numbers)
        {
            List<int> nums = new List<int>();
            foreach (var digit in numbers)
            {
                nums.Add(digit * digit);
            }
            return nums.Sum();
        }
    }
}
