using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu.Added
{
    public class HolidayVIIIDutyFree
    {
        public static int DutyFree(int normPrice, int Discount, int hol)
        {
            double percentage = (double)Discount / 100;
            var savings = normPrice * percentage;
            return (int)Math.Floor(hol / savings);
        }
    }
}
