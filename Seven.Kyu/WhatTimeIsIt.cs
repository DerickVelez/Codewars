using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven.Kyu
{
    public class WhatTimeIsIt
    {
        public static string GetMilitaryTimeFromStandardTime(string time)
        {

            DateTime dateTime;
            if (DateTime.TryParse(time, out dateTime))
            {
                return dateTime.ToString("HH:mm:ss");
            }
            return time;
        }

    }
}
