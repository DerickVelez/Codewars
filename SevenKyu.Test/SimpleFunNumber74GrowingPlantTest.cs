using Seven.Kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKyu.Test
{
    public class SimpleFunNumber74GrowingPlantTest
    {
        [Theory]
        [InlineData(10, 100, 10, 910)]
        [InlineData(1, 10, 9, 4)]

        public static void ShouldReturnOccurence(int expected, int UpSpeed, int DownSpeed, int DesiredHeight)
        {
            var result = SimpleFunNumber74GrowingPlant.GrowingPlant(UpSpeed,DownSpeed,DesiredHeight);
            Assert.Equal(expected, result);
        }
    }
}
