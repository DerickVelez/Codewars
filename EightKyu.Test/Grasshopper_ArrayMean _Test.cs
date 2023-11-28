using Eight.Kyuu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class Grasshopper_ArrayMean__Test
    {
        [Theory]
        [InlineData(new[] { 1 },1)]
        [InlineData(new[] { 1, 3, 5, 7 },4)]
        [InlineData(new[] { -10, -5, -5, 0 },-5)]


        public void ShouldReturnAverage(int[] actual, int expected)
        {
            var result = Grasshopper_ArrayMean.FindAverage(actual);
            Assert.Equal(expected, result);
        }
    }
}
