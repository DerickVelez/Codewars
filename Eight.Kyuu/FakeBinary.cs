using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu
{
    public class FakeBinary
    {
        public static string FakeBin(string x)
        {

            var result = new List<string>();

            foreach (int num in x)
            {
                if (num < '5')
                { result.Add("0"); }
                else
                { result.Add("1"); }
            }

            return string.Join("", result);

        }
    }
}
