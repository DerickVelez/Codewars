using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven.Kyu.Added
{
    public class VowelCount
    {
        public static int GetVowelCount(string str) => str.Count(c => "aeiou".Contains(char.ToLower(c)));

    }
}
