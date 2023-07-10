using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu.Added
{
    public class LarioandLuigiPipeProblem
    {
        public static int[] PipeFix(int[] number)
        {
            var numbers = number.ToList();
            var lastnum = numbers[numbers.Count - 1];
            var arrnum = new List<int>();

            for (int i = numbers[0]; i <= lastnum; i++)
            {
                arrnum.Add(i);
            }
            return arrnum.ToArray();
        }
    }
}
