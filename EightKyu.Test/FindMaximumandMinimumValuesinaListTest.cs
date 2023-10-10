using Eight.Kyuu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class FindMaximumandMinimumValuesinaListTest
    {
        [Theory]
        [InlineData(new int[] { -52, 56, 30, 29, -54, 0, -110 }, 56, -110)]

        public static void ShouldReturnMaxandMin(int[] input, int max, int min)
        {

            var maxResult = FindMaximumandMinimumValuesinaList.Max(input);
            var minResult = FindMaximumandMinimumValuesinaList.Min(input);

            Assert.Equal(max, maxResult);
            Assert.Equal(min, minResult);
        }
    }
}
