using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu.Added
{
    public class GravityFlip
    {
        public static int[] Flip(char dir, int[] arr)
        {

            Array.Sort(arr);

            if (dir == 'L')
            { Array.Reverse(arr); }

            return arr;
        }
    }
}
