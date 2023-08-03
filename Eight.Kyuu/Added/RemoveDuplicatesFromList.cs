using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu.Added
{
    public class RemoveDuplicatesFromList
    {

        public static int[] distinct(int[] a)
        {
            var result = a.Distinct();
            return result.ToArray();
        }

    }
}
