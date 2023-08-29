using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu.Added
{
    public class RemovingElements
    {
        public static object[] RemoveEveryOther(object[] arr)
        {
            List<object> arrays = new List<object>();

            var flag = true;
            foreach (object word in arr)
            {
                if (flag == true)
                {
                    arrays.Add(word);
                }
                flag = !flag;
            }
            return arrays.ToArray();
        }
    }
}
