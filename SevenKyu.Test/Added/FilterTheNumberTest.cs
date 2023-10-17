using Seven.Kyu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKyu.Test.Added
{
    public class FilterTheNumberTest
    {
        [Theory]
        [InlineData(123, "a1b2c3")]
        [InlineData(123, "123")]

        public void ShouldReturnNumbers(int expected, string input)
        {
            var result = FilterTheNumber.FilterString(input);
            Assert.Equal(expected, result);
        }
    }
}
