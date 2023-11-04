using Seven.Kyu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKyu.Test.Added
{
    public class BeginnerSeries5TriangularNumbersTest
    {
        [Theory]
        [InlineData(true, 1)]
        [InlineData(false, 0)]
        [InlineData(true, 6)]
    

        public void ShouldReturnTrueIfTriangleNumber(bool expected, int input)
        {
            var result = BeginnerSeries5TriangularNumbers.isTriangular(input);
            Assert.Equal(expected, result);
        }
    }
}
