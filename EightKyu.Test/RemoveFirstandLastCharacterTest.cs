using Eight.Kyuu;
using Eight.Kyuu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class RemoveFirstandLastCharacterTest
    {
        [Theory]
        [InlineData("loquen", "eloquent")]
        [InlineData("eric","Derick")]

        public void ShouldReturnTrimmedString(string expected, string input)
        {
            var result = RemoveFirstandLastCharacter.Remove_char(input);
            Assert.Equal(expected, result);
        }
    }
}
