using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu
{
    public class String_Templates___Bug_Fixing__5
    {
        public static string buildString(string[] args)
        {
            return String.Format("I like {0}!", String.Join(", ", args));
        }
    }
}
