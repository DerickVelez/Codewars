using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven.Kyu.Added
{
    public static class SumofaSequence
    {
        public static int SequenceSum(int start, int end, int step)
        {
            var added = 0;

            if (start > end) { return 0; }

            for (int i = start; i <= end; i += step)
            {
                added += i;
            }
            return added;
        }
    }
}
