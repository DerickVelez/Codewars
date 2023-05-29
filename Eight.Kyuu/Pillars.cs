using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu
{
    
    public class Pillars
    {
        public static int ReturnPillars(int numPill, int dist, int width)
        {
            if (numPill <= 1 && dist >= 10 && dist <= 30 && width >= 10 && width <= 50)
            { return 0; }
            else
                return ((numPill - 2) * width) + ((numPill - 1) * (dist * 100));
        }
    }
}
