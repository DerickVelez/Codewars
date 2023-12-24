using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu
{
    public class How_old_will_I_be_in_2099
    {
        public static string CalculateAge(int birth, int yearTo)
        {
            var year = Math.Abs(birth - yearTo);

            if (birth < yearTo && year == 1)
            { return $"You are {year} year old."; }

            if (birth < yearTo && year > 1)
            { return $"You are {year} years old."; }

            if (birth > yearTo && year == 1)
            { return $"You will be born in {year} year."; }

            if (birth > yearTo && year > 1)
            { return $"You will be born in {year} years."; }

            else
            { return $"You were born this very year!"; }
        }
    }
}
