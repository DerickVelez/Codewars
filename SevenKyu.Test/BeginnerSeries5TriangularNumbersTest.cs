using Seven.Kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKyu.Test
{
    public class BeginnerSeries5TriangularNumbersTest
    {
        [Theory]
        [InlineData(true, 1)]
        [InlineData(false, 2147483646)]
        [InlineData(true, 0)]

        public void ShouldReturnTrueIfTriangleNumber(bool expected, int input)
        {
            var result = BeginnerSeries5TriangularNumbers.isTriangular(input);
            Assert.Equal(expected, result);
        }
    }
}
