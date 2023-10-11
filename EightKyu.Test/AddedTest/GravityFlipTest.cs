using Eight.Kyuu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test.AddedTest
{
    public class GravityFlipTest
    {
        [Theory]
        [InlineData(new int[] { 1, 4, 5, 6, 7 }, 'R', new int[] { 4, 5, 6, 7, 1 })]
        [InlineData(new int[] { 2, 4, 7, 13, 93 }, 'R', new int[] { 13, 2, 4, 7, 93 })]
        [InlineData(new int[] { 12, 1, 0, 0, 0 }, 'L', new int[] { 12, 1, 0, 0, 0 })]

        public void ShouldReturnSortedArray(int[] expected, char dir, int[] arr)
        {
            var result = GravityFlip.Flip(dir, arr);
            Assert.Equal(expected, result);
        }
    }
}
