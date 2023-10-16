using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven.Kyu.Added
{
    public static class LengthofTwoValues
    {
        public static object[] AlternateObjectArray(int n, object firstValue, object secondValue)
        {

            List<object> Objlist = new List<object>();

            var flag = true;

            for (int i = 1; i <= n; i++)
            {
                if (flag == true)
                    Objlist.Add(firstValue);
                else
                { Objlist.Add(secondValue); }
                flag = !flag;
            }
            object[] objArray = Objlist.ToArray();
            return objArray;
        }
    }
}
