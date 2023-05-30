using Seven.Kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKyu.Test
{
    public class SumofaSequenceTest
    {
        [Theory]
        [InlineData(2, 6, 2, 12)]
        [InlineData(1, 15, 3, 35)]
        [InlineData(16, 15, 3, 0)]
        public void ShouldReturnSum(int start,int end,int steps,int expected)
        {
            var result = SumofaSequence.SequenceSum(start, end, steps);
            Assert.Equal(expected, result);
        }
    }
}
