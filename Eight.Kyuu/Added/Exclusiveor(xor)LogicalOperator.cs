using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu
{
    public class Exclusiveor_xor_LogicalOperator
    {
        public static bool Xor(bool a, bool b)
        {
            if (a == false && b == false || a == true && b == true)
            { return false; }
            else
                return true;
        }
    }
}
