using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six_Kyu
{
    public class FindthePartyOutlier
    {
        public static int Find(int[] integers)
        {
            int oddCounter = 0;
            int evenCounter = 0;
            int odd = 0;
            int even = 0;

            while (oddCounter < 2 || evenCounter < 2)
            {
                foreach (int digits in integers)
                {
                    if (digits % 2 == 0)
                    {
                        evenCounter++;
                        even = even = +digits;
                    }
                    else
                    {
                        oddCounter++;
                        odd = odd = +digits;
                    }
                }
            }

            if (oddCounter > evenCounter)
            { return even; }
            else
            { return odd; }

        }
    }
}
