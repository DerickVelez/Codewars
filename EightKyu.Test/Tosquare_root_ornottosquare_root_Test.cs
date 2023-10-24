using Eight.Kyuu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class Tosquare_root_ornottosquare_root_Test
    {
        [Theory]
        [InlineData(new int[] { 4, 3, 9, 7, 2, 1 }, new int[] { 2, 9, 3, 49, 4, 1 })]
        [InlineData(new int[] { 100, 101, 5, 5, 1, 1 }, new int[] { 10, 10201, 25, 25, 1, 1 })]

        public void ShouldReturnArrayOfSquareRoots(int[] input ,int[] expected)
        {
            var result = Tosquare_root_ornottosquare_root_.SquareOrSquareRoot(input);

            Assert.Equal(expected, result);
        }

    }
}
