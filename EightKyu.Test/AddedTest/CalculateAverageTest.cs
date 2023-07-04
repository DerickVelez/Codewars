using Eight.Kyuu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test.AddedTest
{
    public class CalculateAverageTest
    {
        [Theory]
        [InlineData(new double[] { 17, 16, 16, 16, 16, 15, 17, 17, 15, 5, 17, 17, 16 }, 200.0 / 13.0)]

        public void ShouldReturnAverage(double[] input, double expected)
        {
            var result = CalculateAverage.FindAverage(input);
            Assert.Equal(expected, result);

        }
    }
}
