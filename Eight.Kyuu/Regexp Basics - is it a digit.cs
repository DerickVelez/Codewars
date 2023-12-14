using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Eight.Kyuu
{
    public static class Regexp_Basics___is_it_a_digit
    {
        public static bool Digit(this string s)
        {

            string pattern = @"^-?[0-9][0-9,\.]+$";

            var answer = Regex.IsMatch(s, pattern);
            if (answer == true)
            {

                return true;
            }
            else
                Console.WriteLine(s);
            return false;
        }
    }
}
