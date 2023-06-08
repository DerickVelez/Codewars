using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu
{
    public static class ReversedSequence
    {
        public static int[] ReverseSeq(int n)
        {
            List<int> numbers = new List<int>();

            while (n > 0)
            {
                numbers.Add(n);
                n--;
            }
            return numbers.ToArray();
        }
    }
}
