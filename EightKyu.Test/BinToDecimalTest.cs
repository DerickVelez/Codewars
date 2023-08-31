using Eight.Kyuu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class BinToDecimalTest
    {
        [Theory]
        [InlineData("0",0)]
        [InlineData("1",1)]
        [InlineData("2",10)]

        public void ShouldReturnBinaryEquivalent(string value, int expected)

        {
            var result = BintoDecimal.binToDec(value);
            Assert.Equal(expected, result);
        }
    }
}
