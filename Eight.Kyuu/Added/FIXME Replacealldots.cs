using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Eight.Kyuu.Added
{
    public class FIXME_Replacealldots
    {
        public static string ReplaceDots(string str)
        {
            return Regex.Replace(str, @"\.", "-");
        }
    }
}
