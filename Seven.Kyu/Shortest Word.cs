using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven.Kyu
{
    public class Shortest_Word
    {
        public static int FindShort(string s)
        {
            var final = s.Split(" ");
            return final.Min(y => y.Length);
        }
    }
}
