using Eight.Kyuu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class GerCharacterFromASCIIValueTest
    {
        [Theory]
        [InlineData( '7', 55)]
        [InlineData( '@',64)]
        [InlineData( 'A',65)]

        public void ShouldReturnASCIIValue(int charcode, char expected)
        {
            var result = GetCharacterFromASCIIValue.GetChar(charcode);
            Assert.Equal(expected, result);
        }
    }
}
