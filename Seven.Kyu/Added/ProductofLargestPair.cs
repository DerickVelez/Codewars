using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven.Kyu.Added
{
    public static class ProductofLargestPair
    {
        public static int MaxProduct(int[] array)
        {
            Array.Sort(array);
            return array[array.Length - 1] * array[array.Length - 2];
        }
    }
}
