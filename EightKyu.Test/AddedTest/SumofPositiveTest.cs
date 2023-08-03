using Eight.Kyuu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test.AddedTest
{
    public class SumofPositiveTest
    {
        [Theory]
        [InlineData(15, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(13, new int[] { 1, -2, 3, 4, 5 })]

        public void ShouldReturnSumOfPositive(int expected, int[] input)
        {
            var result = SumOfPositive.PositiveSum(input);
            Assert.Equal(expected, result);
        }
    }
}
