using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu
{
    public class Exclamation_marks_series_1_Remove_an_exclamation_mark_from_the_end_of_string
    {
        public static string Remove(string s)
        {
            if (s.EndsWith("!"))
                return s.Substring(0, s.Length - 1);
            return s;
        }
    }
}
