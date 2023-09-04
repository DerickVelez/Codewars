using Eight.Kyuu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class ConvertaBooleantoaStringTest
    {
        [Theory]
        [InlineData("True",true)]
        [InlineData("False",false)]

        public void ShouldReturnTrueorFalse(string expected, bool input)
        {
            var result = ConvertaBooleantoaString.BooleanToString(input);
            Assert.Equal(expected, result);
        }
    }
}
