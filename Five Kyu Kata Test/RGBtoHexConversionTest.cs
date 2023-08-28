using Five_Kyu_Kata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five_Kyu_Kata_Test
{
    public class RGBtoHexConversionTest
    {
        [Theory]
        [InlineData("FFFFFF", 255, 255, 255)]
        [InlineData("FFFFFF", 255, 255, 300)]
        [InlineData("9400D3", 148, -20, 211)]

        public void ShouldReturnHexConversion(string expected, int r, int g, int b)
        {
            var result = RGBtoHexConversion.Rgb(r,g, b);
            Assert.Equal(expected, result);
        }
    }
}
