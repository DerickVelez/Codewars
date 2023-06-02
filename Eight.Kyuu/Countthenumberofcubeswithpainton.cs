using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu
{
    public static class Countthenumberofcubeswithpainton
    {
        public static int CountSquares(int cuts)
        {
            if (cuts == 0)
            {
                return 1;
            }
            int side1 = ((cuts + 1) * (cuts + 1)) * 2;
            int side2 = (cuts - 1) * (((cuts + 1) * 4) - 4);
            return side1 + side2;
        }
    }
}
