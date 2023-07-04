using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu
{
    public class NoZerosforHeroes
    {

        public static int NoBoringZeros(int n)
        {
            string numberString = n.ToString();
            var EndIndex = numberString.Length - 1;

            List<string> digits = new List<string> { "1" };
            int i = EndIndex;

            if (n == 0)
            { return n; }
            else

                while (numberString[i] == '0')
                {
                    digits.Add("0");
                    i--;
                }

            string numbers = string.Join("", digits);
            int result = Int32.Parse(numbers);
            return n / result;
        }
    }
}
