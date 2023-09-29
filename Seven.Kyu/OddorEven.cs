using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven.Kyu
{
    public class OddorEven
    {
        public static string OddOrEven(int[] array)
        {
            var result = array.Sum();
            return (result % 2 == 0) ? "even" : "odd";
        }
    }
}
