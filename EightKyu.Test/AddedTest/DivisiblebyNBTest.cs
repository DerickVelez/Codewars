using Eight.Kyuu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class DivisiblebyNBTest
    {
        [Theory]
        [InlineData(true, 12,4,3)]
        [InlineData(false, 9 ,4,3)]

        public void ShouldReturnTrueifDivisible(bool expected, int val, int x, int y)
        {
            var result = DivisiblebyNB.IsDivisible(val, x, y);
            Assert.Equal(expected, result);
        }
    }
}
