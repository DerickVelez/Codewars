using Seven.Kyu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKyu.Test.Added
{
    public class ReturntheClosestNumberMultipleofTenTest
    {
        [Theory]
        [InlineData(12785, 12790)]
        [InlineData(2344, 2340)]
        public void ShouldReturnMultipleofTen(int num, int expected)
        {
            var result = ReturntheClosestNumberMultipleofTen.ClosestMultiple10(num);
            Assert.Equal(expected, result);
        }
    }
}
