using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven.Kyu.Added
{
    public static class GettheMiddleCharacter
    {
        public static string GetMiddle(string s)
        {
            int strlen = s.Length / 2;

            if (s.Length % 2 == 0)//even
            {
                return string.Concat(s[strlen - 1].ToString(), s[strlen].ToString());
            }
            else//odd
                return s[strlen].ToString();
        }
    }
}
