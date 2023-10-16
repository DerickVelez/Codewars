using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven.Kyu.Added
{
    public static class CatsAndShelves
    {
        public static int Cats(int start, int finish)
        {
            int difference = finish - start;
            return (int)Math.Floor((double)difference / 3) + difference % 3;
        }
    }
}
