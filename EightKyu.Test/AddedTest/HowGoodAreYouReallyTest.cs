using Eight.Kyuu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test.AddedTest
{
    public class HowGoodAreYouReallyTest
    {
        [Theory]
        [InlineData(new int[] { 100, 40, 34, 57, 29, 72, 57, 88 }, 75, true)]

        public void ShouldReturnTrueIfBetterthanAve(int[] ClassPoint, int YourPoints, bool expected)
        {
            var result = HowGoodAreYouReally.BetterThanAverage(ClassPoint, YourPoints);
            Assert.Equal(expected, result);
        }
    }
}
