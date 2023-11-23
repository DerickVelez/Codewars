using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu
{
    public class IsItaNumber
    {
        public static bool IsDigit(string s)
        {
            if (double.TryParse(s, out double result))
            { return true; }
            else
            { return false; }
        }
    }
}
