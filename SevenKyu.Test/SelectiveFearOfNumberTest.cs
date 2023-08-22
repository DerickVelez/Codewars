using Seven.Kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKyu.Test
{
    public class SelectiveFearOfNumberTest
    {
        [Theory]
        [InlineData(true, "Monday", 12)]
        [InlineData(true,"Tuesday", 100)]

        public void ShouldReturnTrueIfInRecord(bool expected, string day,  int count)
        {
            var result = SelectiveFearOfNumber.AmIAfraid(day, count);
            Assert.Equal(expected, result);
        }
    }
}
