using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five_Kyu_Kata
{
    public class HumanReadableTime
    {
        public static string GetReadableTime(int seconds)
        {
            if (seconds > 359999 || seconds < 1)
            { return "00:00:00"; }

            double HH = seconds / 3600;
            var diff = seconds - (Math.Floor(HH) * 3600);
            double MM = diff / 60;

            if (diff > 3481)
            { MM = 59; }

            double SS = diff - (Math.Floor(MM) * 60);

            return $"{HH.ToString("00")}:{Math.Floor(MM).ToString("00")}:{SS.ToString("00")}";

        }
    }
}
