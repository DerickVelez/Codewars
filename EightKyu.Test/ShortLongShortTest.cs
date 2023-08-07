using Eight.Kyuu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class ShortLongShortTest
    {
        [Fact]

        public void ShouldReturnShortLongShortSequence()
        {
            var expected = "abba";
            var actualA = "a";
            var actualB = "bb";

            var result = ShortLongShort.Solution(actualA, actualB);
            Assert.Equal(expected, result);
        }
    }
}
