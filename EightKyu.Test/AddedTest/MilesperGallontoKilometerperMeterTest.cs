using Eight.Kyuu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test.AddedTest
{
    public class MilesperGallontoKilometerperMeterTest
    {
        [Theory]
        [InlineData(3.54, 10)]
        [InlineData(7.08, 20)]
        [InlineData(8.50, 24)]

        public void ShouldReturnResult(double expected, int count)
        {
            var result = MilesperGallontoKilometerperMeter.Converter(count);
            Assert.Equal(expected, result);
        }


    }
}
