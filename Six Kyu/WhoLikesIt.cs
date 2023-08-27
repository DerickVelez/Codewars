using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six_Kyu
{
    public class WhoLikesIt
    {
        public static string Likes(string[] name)
        {
            var count = name.Length;

            if (count == 0)
            { return "no one likes this"; }
            if (count == 1)
            { return $"{name[0]} likes this"; }
            if (count == 2)
            { return $"{name[0]} and {name[1]} like this"; }
            if (count == 3)
            { return $"{name[0]}, {name[1]} and {name[2]} like this"; }

            else
                return $"{name[0]}, {name[1]} and {count - 2} others like this";
        }
    }
}
