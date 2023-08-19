using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu
{
    public class RemoveFirstandLastCharacterPartTwo
    {
        public static string Array(string s)
        {
            var digits = s.Split(",");

            if (digits.Length < 3)
                return null;

            return string.Join(" ", digits.Take(digits.Length - 1).Skip(1));


        }

    }
}
