using Seven.Kyu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKyu.Test.Added
{
    public class BoiledEggsTest
    {

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 5)]
        [InlineData(10, 10)]
        [InlineData(11,15)]

        public void ShouldReturnNumofBoiledEggs(int input, int expected)
        {
            var result = BoiledEggs.CookingTime(input);
            Assert.Equal(expected, result);
        }
    }
}
