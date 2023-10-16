using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven.Kyu.Added
{
    public class ReturntheClosestNumberMultipleofTen
    {
        public static int ClosestMultiple10(int num)
        {
            Console.WriteLine(num);
            return (int)Math.Round(num / 10.000, MidpointRounding.AwayFromZero) * 10;

        }
    }
}
