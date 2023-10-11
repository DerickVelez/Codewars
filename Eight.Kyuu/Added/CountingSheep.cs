using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu.Added
{
    public class CountingSheep
    {
        public static int CountSheeps(bool[] sheeps)
        {
            return sheeps.Count(s => s == true);
        }
    }
}
