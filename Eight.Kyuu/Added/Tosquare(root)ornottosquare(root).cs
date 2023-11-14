using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu
{
    public class Tosquare_root_ornottosquare_root_
    {
        public static int[] SquareOrSquareRoot(int[] array)
        {
            List<int> result = new List<int>();

            foreach (var num in array)
            {
                var digit = Math.Sqrt(num);

                if (digit % 1 == 0)
                { result.Add((int)digit); }
                else
                { result.Add(num * num); }
            }
            return result.ToArray();
        }
    }
}
