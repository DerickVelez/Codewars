using Eight.Kyuu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class MultipleOfIndexTest
    {
        [Theory]
        [InlineData(new int[] { 22, -6, 32, 82, 9, 25 }, new int[] { -6, 32, 25 })]

        public static void ShouldReturnIndeces(int[] input, int[] expected)
        {
            var result = MultipleOfIndex.MultipleOfIndeces(input);
            Assert.Equal(expected, result);
        }
    }
}
