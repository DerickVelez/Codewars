using Eight.Kyuu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class StringyStringTest
    {
        [Theory]
        [InlineData("1010101010",10)]
        [InlineData("10",2)]
        [InlineData("",0)]

        public void ShouldReturnConvertedBinary(string expected, int input)
        {
            var result = StringyStrings.Stringy(input);
            Assert.Equal(expected, result);
        }

    }
}
