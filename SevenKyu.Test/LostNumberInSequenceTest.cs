using Seven.Kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKyu.Test
{
    public class LostNumberInSequenceTest
    {
        [Theory]
        [InlineData(6, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new int[] { 5, 7, 1, 9, 4, 8, 2, 3 })]
        public void ShouldReturnMissingNum(int expected,int[] Alist, int[] Blist)
        {
            var result = LostNumberInSequence.FindDeletedNumber(Alist, Blist);
            Assert.Equal(expected, result);
        }

    }
}
