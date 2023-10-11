using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu.Added
{
    public class RemoveFirstandLastCharacter
    {
        public static string Remove_char(string s)
        {
            return s.Substring(1).Substring(0, s.Length - 2);
        }
    }
}
