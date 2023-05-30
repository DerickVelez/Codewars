using Eight.Kyuu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class AverageSolutionTest
    {
        [Theory]
        [InlineData(new double[] {7, 16, 16, 16, 16, 15, 17, 17, 15, 5, 17, 17, 16} ,200/13)]
        [InlineData(new double[] {0,0,0,0}, 0)]
        public void shouldReturnAverage(double[] array,double expected)
        {
            var result = Math.Round(AverageSolution.FindAverage(array),0);
            Assert.Equal(expected, result);

        }
    }
}
