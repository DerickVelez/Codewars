using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Seven.Kyu.Added
{
    public class ReturnSubstringInstanceCount
    {
        public static int SubstringCount(string fullText, string searchText)
        {
            return new Regex(Regex.Escape(searchText)).Matches(fullText).Count;
        }
    }
}
