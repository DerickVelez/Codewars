using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Seven.Kyu.Added
{
    public class HowmanyurinalsareFree
    {
        public static int GetFreeUrinals(string urinals)
        {
            return urinals.Contains("11") ? -1 : Regex.Matches(urinals, @"(^|0)0(?!1)").Count;
        }
    }
}
