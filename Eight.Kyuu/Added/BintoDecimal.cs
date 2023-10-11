using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu
{
    public class BintoDecimal
    {
        public static int binToDec(string s)
        {
            return Convert.ToInt32(s, 2);
        }
    }
}
