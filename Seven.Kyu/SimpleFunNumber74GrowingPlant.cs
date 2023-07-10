using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven.Kyu
{
    public class SimpleFunNumber74GrowingPlant
    {
        public static int GrowingPlant(int UpSpeed, int DownSpeed, int DesiredHeight)
        {
            int plantHeight = 0;
            int i = 0;

            while (DesiredHeight > plantHeight)
            {
                if (DesiredHeight > plantHeight)
                { plantHeight += UpSpeed; }

                if (DesiredHeight > plantHeight)
                { plantHeight -= DownSpeed; }
                ++i;
            }
            return i;
        }
    }
}
