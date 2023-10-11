using Eight.Kyuu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test.AddedTest
{
    public class ConvertBooleanValueToaStringTest
    {
        [Theory]
        [InlineData("Yes", true)]
        [InlineData("No", false)]

        public void ShouldReturnConvertedValue(string expected, bool value)
        {
            var result = ConvertBooleanValuetoaString.boolToWord(value);
            Assert.Equal(expected, result);
        }
    }
}
