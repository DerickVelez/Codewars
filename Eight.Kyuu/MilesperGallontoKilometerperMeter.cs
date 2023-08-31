using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu
{
    public class MilesperGallontoKilometerperMeter
    {
        public static double Converter(int mpg)
        {
            return Math.Round(((mpg / 4.54609188) * 1.609344), 2);
        }
    }
}
