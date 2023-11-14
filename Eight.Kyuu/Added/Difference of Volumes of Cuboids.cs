using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu
{
    public class Difference_of_Volumes_of_Cuboids
    {
        public static int FindDifference(int[] a, int[] b)
        {
            int a1 = 1;
            int b1 = 1;


            for (var i = 0; a.Length > i; i++)
            { a1 = a[i] * a1; }
            for (var i = 0; b.Length > i; i++)
            { b1 = b[i] * b1; }
            return Math.Abs(a1 - b1);

        }
    }
}
