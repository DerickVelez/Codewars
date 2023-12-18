using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven.Kyu
{
    public class Calculate_Total_Meal
    {
        public static double CalculateTotal(double subtotal, int tax, int tip)
        {
            var taxedTotal = (tax * 0.01) * subtotal;
            var tipTotal = (tip * 0.01) * subtotal;
            return Math.Round(taxedTotal + tipTotal + subtotal, 2);
        }
    }
}
