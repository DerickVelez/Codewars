using Eight.Kyuu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class GetAsciiValueofCharacterTest
    {
        [Theory]
        [InlineData(65,'A')]
        [InlineData(32,' ')]

        public void ShouldReturnASCIIValue(int expected, char value)
        {
            var result = GetAsciiValueofCharacter.GetASCII(value);
            Assert.Equal(expected, result);
        }
    }
}
