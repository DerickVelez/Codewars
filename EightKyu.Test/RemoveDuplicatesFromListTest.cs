using Eight.Kyuu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class RemoveDuplicatesFromListTest
    {
        [Theory]
        [InlineData(new int[] { 1 }, new int[] { 1 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7 } , new int[] { 1, 2, 2, 3, 3, 4, 4, 5, 6, 7, 7, 7 })]

        public void ShouldReturnDistinctnum(int[] expected, int[] input)
        {
            var result = RemoveDuplicatesFromList.distinct(input);
             Assert.Equal(expected, result);
        }
    }
}
