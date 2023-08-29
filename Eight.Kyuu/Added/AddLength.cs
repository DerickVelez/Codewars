using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu.Added
{
    public class AddLength
    {
        public static string[] AddLengthInString(string str)
        {
            var words = str.Split();
            var result = new List<string>();

            foreach (string subword in words)
            {
                result.Add($"{subword} {subword.Length.ToString()}");
            }
            return result.ToArray();
        }
    }
}
