using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu.Added
{
    public static class AverageSolution
    {
        public static double FindAverage(double[] array)
        {
            if (array.Length <= 0) { return 0; }


            double ave = array.Sum() / array.Length;
            return ave;
        }
    }
}
