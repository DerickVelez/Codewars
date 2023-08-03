using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu.Added
{
    public class SumofMultiples
    {
        public static int SumMul(int n, int m)
        {

            if (n == 0 && m > 0 || n < 0 || m < 0 || n > m)
                throw new ArgumentException();

            List<int> numbers = new List<int>();
            int i = n;

            while (i < m)
            {
                numbers.Add(i);
                i = i + n;
            }
            return numbers.Sum(x => Convert.ToInt32(x));
        }
    }
}
