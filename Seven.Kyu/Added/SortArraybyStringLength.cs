using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven.Kyu.Added
{
    public class SortArraybyStringLength
    {
        public static string[] SortByLength(string[] array)
        {
            string secArr;
            bool isSorted = false;
            while (isSorted == false)
            {
                isSorted = true;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i].Length > array[i + 1].Length)
                    {
                        secArr = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = secArr;
                        isSorted = false;
                    }

                }
            }
            return array;
        }
    }
}
