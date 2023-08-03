using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu.Added
{
    public class IsHeGonnaSurvive
    {
        public static bool Hero(int bullets, int dragons)
        {
            if (dragons * 2 <= bullets)
            {
                return true;
            }
            return false;
        }
    }
}
