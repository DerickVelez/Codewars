using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu
{
    public static class MultipleOfIndex
    {
        public static int[] MultipleOfIndeces(int[] xs)
        {
            List<int> res = xs.ToList();
            List<int> result = new List<int>();


            for (int i = 0; i < res.Count; i++)
            {

                if ((xs[i] == 0 && i == 0) || (i != 0 && xs[i] % i == 0))
                {
                    result.Add(xs[i]);
                }

            }

        

            return result.ToArray();
        }
    }
}
