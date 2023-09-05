using Eight.Kyuu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class WhatisBetweenTest
    {
 
        [Theory]
        [InlineData(new int[] { 0, 1, 2, 3 },0,3)]
        [InlineData(new int[] { -2, -1, 0, 1, 2 }, -2, 2)]

        public void ShouldReturnBetweenNumbers(int[] expected, int a, int b)
        {
            var result = WhatisBetween.Between(a, b);
            Assert.Equal(expected, result);
        }
    }
}
