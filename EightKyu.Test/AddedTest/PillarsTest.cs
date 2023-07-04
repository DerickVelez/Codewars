using Eight.Kyuu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test.AddedTest
{
    public class PillarsTest
    {
        [Theory]
        [InlineData(11, 15, 30, 15270)]
        public void PillarsTestshouldreturnDist(int numPill, int dist, int width, int expected)
        {

            var result = Pillars.ReturnPillars(numPill, dist, width);

            Assert.Equal(expected, result);

        }

    }
}
