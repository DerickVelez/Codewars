using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu
{
    public class ShortLongShort
    {
        public static string Solution(string a, string b) => a.Length < b.Length ? a + b + a : b + a + b;

    }
}
