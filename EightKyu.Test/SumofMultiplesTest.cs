using Eight.Kyuu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class SumofMultiplesTest
    {
        [Theory]
        [InlineData(86469, 123, 4567)]
        [InlineData(1860, 4, 123)]

        public void ShouldReturnSumofMultiples(int expected, int n , int m)
        {
            var result = SumofMultiples.SumMul(n, m);
            Assert.Equal(expected, result);
        }
    }
}
