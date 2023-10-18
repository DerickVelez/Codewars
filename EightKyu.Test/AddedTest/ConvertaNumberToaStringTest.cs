using Eight.Kyuu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test.AddedTest
{
    public class ConvertaNumberToaStringTest
    {
        [Theory]
        [InlineData("67", 67)]
        [InlineData("1", 1)]
        [InlineData("3",3)]
    
        public void ShouldReturnStringFormat(string expected, int actual)
        {
            var result = ConvertaNumberToaString.NumberToString(actual);
            Assert.Equal(expected, result);
        }
    }
}
