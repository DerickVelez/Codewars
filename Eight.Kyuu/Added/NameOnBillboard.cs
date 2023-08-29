using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu.Added
{
    public class NameOnBillboard
    {
        public static double Billboard(string name, double price = 30)
        {

            double adPrice = 0;

            for (var i = 0; i < name.Length; i++)
            {
                adPrice = adPrice += price;
            }
            return adPrice;
        }
    }
}
