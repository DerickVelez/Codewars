using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu.Added
{
    public class AddLength
    {
        public static bool IsDigit(string s)
        {
            var correct;
            bool Isnumerical = int.TryParse(s, out correct);

            if (Isnumerical == true)
            { return true; }
            else
            { }

            return Isnumerical;
        }
    }
}
