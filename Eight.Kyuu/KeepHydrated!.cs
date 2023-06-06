using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu
{
    public static class KeepHydrated
    {
        public static int Litres(double time) => Convert.ToInt32((double)Math.Floor(time * 0.5));
    }
}
