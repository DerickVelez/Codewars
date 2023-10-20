using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven.Kyu.Added
{
    public class NumberPairs
    {
        public static int[] getLargerNumbers(int[] a, int[] b)
        {
            int arrcount = a.Length;
            var arrAll = a.Union(b);
            var result = new List<int>();

            for (var i = 0; i >= arrcount; i++)
            {
                result.Add(arrAll.Max());
                Console.WriteLine(arrAll.Max());
            }

            return result.ToArray();
        }
    }
}
