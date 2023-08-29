using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu.Added
{
    public class DoubleChar
    {
        public static string CharChar(string s)
        {
            var sb = new StringBuilder();
            List<string> name = new List<string>();

            var output = "";

            foreach (char letter in s)
            {


                output += $"{letter}{letter}";

                //          using StringBuilder  
                //          sb.Append(letter);
                //          sb.Append(letter);

                //          using Lists
                //          name.Add(letter.ToString());
                //          name.Add(letter.ToString());
            }

            //          return string.Join("",name);
            //          return sb.ToString();
            return output;
        }
    }
}
