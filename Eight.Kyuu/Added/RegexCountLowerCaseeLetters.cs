using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Eight.Kyuu.Added
{
    public class RegexCountLowerCaseeLetters
    {
        public static int LowercaseCountCheck(string s)
        {
            return Regex.Matches(s, @"\p{Ll}").Count;
        }
    }
}
