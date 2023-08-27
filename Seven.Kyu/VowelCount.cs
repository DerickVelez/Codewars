using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven.Kyu
{
    public class VowelCount
    {
        public static int GetVowelCount(string str) => str.Count(c => "aeiou".Contains(Char.ToLower(c)));

    }
}
