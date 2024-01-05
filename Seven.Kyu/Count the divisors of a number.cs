using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven.Kyu
{
    public   class Count_the_divisors_of_a_number
    {

        //Cannot handle big numbers
        public static int Divisors(int n)
        {
            int count = 0;

            for (int i = n; i > 0; i--)
            {
                if (n % i == 0)
                {
                    count++;
                }
                else
                { Console.WriteLine("nothing"); }
            }
            return count;
        }
    }
}
