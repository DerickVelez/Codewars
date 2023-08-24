using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu
{
    public class StringyStrings
    {
        public static string Stringy(int size)
        {
            List<string> result = new List<string>();
            var flag = true;
            for (var i = 0; i < size; i++)
            {
                if (flag == true)
                {
                    result.Add("1");
                }
                else
                { result.Add("0"); }

                flag = !flag;
            }

            return string.Join("", result);
        }
    }
}
