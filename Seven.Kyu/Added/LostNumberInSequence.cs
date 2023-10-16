using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven.Kyu.Added
{
    public class LostNumberInSequence
    {
        public static int FindDeletedNumber(int[] AstartingList, int[] BmixedList)
        {
            var startingList = AstartingList.ToList();
            var mixedList = BmixedList.ToList();
            var missingnumber = startingList.Except(mixedList);

            int numbers = 0;
            foreach (int number in missingnumber)
            { numbers = +number; }

            return numbers;

        }
    }
}
