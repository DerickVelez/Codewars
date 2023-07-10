using Eight.Kyuu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test.AddedTest
{
    public class LarioandLuigiPipeProblemTest
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new int[] { 1, 2, 3, 5, 6, 8, 9 })]

        public void ShouldReturnResult(int[] expected, int[] input)
        {
            var result = LarioandLuigiPipeProblem.PipeFix(input);
            Assert.Equal(expected, result);
        }
    }
}
