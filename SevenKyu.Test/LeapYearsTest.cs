using Seven.Kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKyu.Test
{
    public class LeapYearsTest
    {
        [Theory]
        [InlineData(true,1600)]
        [InlineData(false, 2200)]
        
        public void ShouldReturnLeapYear(bool expected,  int year)
        {
            var result = LeapYear.IsLeapYear(year);
            Assert.Equal(expected, result);
        }
    }
}
