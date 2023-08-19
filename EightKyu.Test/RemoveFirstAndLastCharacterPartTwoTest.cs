using Eight.Kyuu;
using Eight.Kyuu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class RemoveFirstAndLastCharacterPartTwoTest
    {
        [Theory]
        [InlineData(null, "")]
        [InlineData("2 3", "1,2,3,4")]

        public void ShouldReturnFirlteredString(string expected, string input)
        {
            var result = RemoveFirstandLastCharacterPartTwo.Array(input);
            Assert.Equal(expected, result);
        }
    }
}
