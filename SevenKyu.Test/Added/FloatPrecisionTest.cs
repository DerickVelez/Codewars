using Seven.Kyu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKyu.Test
{
    public class FloatPrecisionTest
    {
        [Theory]
        [InlineData("1.14", 1.1356)]
        [InlineData("2.35", 2.34545)]
        [InlineData("445.23", 445.234234)]

        public void ShouldReturnRoundedNum(string expected, float precision)
        {
            var result = FloatPrecision.Round(precision);
            Assert.Equal(expected, result);
        }
    }
}
