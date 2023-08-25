using Six_Kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixKyu.Test
{
    public class MutliplesOf3and5Test
    {
        [Theory]
        [InlineData(23,10)]
        [InlineData(78,20)]
        [InlineData(9168,200)]
        [InlineData(0,0)]

        public void ShouldReturnMultiplesSum(int expected, int input)

        {
            var result = MultiplesOf3and5.Solution(input);
            Assert.Equal(expected, result);
        }
    }
}
