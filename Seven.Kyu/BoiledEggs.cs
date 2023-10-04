using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven.Kyu
{
    public class BoiledEggs
    {
        public static int CookingTime(int eggs) =>
    eggs <= 0 ? 0 : (int)Math.Ceiling((double)eggs / 8) * 5;

    }
}
