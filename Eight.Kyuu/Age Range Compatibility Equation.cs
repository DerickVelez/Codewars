using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu
{
    public class Age_Range_Compatibility_Equation
    {
        public static string DatingRange(int age)
        {
            var min = 0;
            var max = 0;

            if (age <= 14)
            {
                min = (int)Math.Floor(age - 0.10 * age);
                max = (int)Math.Floor(age + 0.10 * age);
            }
            else
            {
                min = (age / 2) + 7;
                max = (age - 7) * 2;
            }
            return $"{min}-{max}";
        }
    }
}
