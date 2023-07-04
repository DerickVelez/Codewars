using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu.Added
{
    public static class HowGoodAreYouReally
    {
        public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        {
            var ave = ClassPoints.Sum() / ClassPoints.Count();

            if (YourPoints > ave)
            {
                return true;
            }
            else
                return false;
        }
    }
}
