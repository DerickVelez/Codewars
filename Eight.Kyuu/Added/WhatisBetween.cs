using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu.Added
{
    public class WhatisBetween
    {
        public static int[] Between(int a, int b)
        {

            var list = new List<int>();

            while (a <= b)
            {
                list.Add(a);
                a++;
            }
            return list.ToArray();
        }
    }
}
