using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven.Kyu
{
    public class SelectiveFearOfNumber
    {
        public static bool AmIAfraid(string day, int num)
        {
            if (day == "Monday" && num == 12)
                return true;
            if (day == "Wednesday" && num == 34)
                return true;
            if (day == "Saturday" && num == 56)
                return true;
            if (day == "Sunday" && num == 666 || num == -666)
                return true;
            if (day == "Thursday" && num == 0)
                return true;
            if (day == "Friday" && num % 2 == 0)
                return true;
            if (day == "Tuesday" && num > 95)
                return true;
            else
                return false;

        }
    }
}
