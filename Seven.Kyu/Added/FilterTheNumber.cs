using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven.Kyu.Added
{
    public class FilterTheNumber
    {
        public static int FilterString(string s)
        {
            return int.Parse(new string(s.Where(char.IsDigit).ToArray()));
        }
    }
}
