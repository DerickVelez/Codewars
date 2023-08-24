using Seven.Kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKyu.Test
{
    public class BreakingChocolateProblemTest
    {
        [Theory]
        [InlineData(24,5,5)]
        [InlineData(27,7,4)]
        [InlineData(0,1,1)]
        [InlineData(0,0,0)]
        [InlineData(5,6,1)]

        public void ShouldReturnNumberOfBreaks(int expected, int n, int m)
        {
            var result = BreakingChocolateProblem.BreakChocolate(n, m);
            Assert.Equal(expected, result);
        }
    }
}
