using Eight.Kyuu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test.AddedTest
{
    public class Square_n_SumTest
    {
        [Theory]
        [InlineData(9, new int[] { 1, 2, 2 })]
        [InlineData(50, new int[] { 5, 3, 4 })]
        [InlineData(5, new int[] { 1, 2 })]

        public void ShouldReturnSquaredOfNums(int expected, int[] nums)
        {
            var result = Square_n_Sum.SquareSum(nums);
            Assert.Equal(expected, result);

        }

    }
}
