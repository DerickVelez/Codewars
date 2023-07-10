using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu.Added
{
    public class VowelRemover
    {
        public static string Shortcut(string input)
        {
            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            var result = new string(input.Where(c => !vowels.Contains(c)).ToArray());

            return result;
        }
    }
}
