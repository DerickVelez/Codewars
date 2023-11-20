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
            bool correct = true;
            bool Isnumerical = int.TryParse(s, out correct);

            return Isnumerical;
        }
    }
}
