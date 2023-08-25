using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six_Kyu
{
    public class MultiplesOf3and5
    {
        public static int Solution(int value)
        {
            var multiples = new List<int> { };

            for (var i = 0; i < value; i += 3)
            {
                multiples.Add(i);
            }
            for (var i = 0; i < value; i += 5)
            {
                multiples.Add(i);
            }

            return multiples.Distinct().Sum();
        }
    }
}
