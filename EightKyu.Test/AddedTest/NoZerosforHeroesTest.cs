using Eight.Kyuu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test.AddedTest
{
    public class NoZerosforHeroesTest
    {
        [Theory]
        [InlineData(145, 1450)]
        [InlineData(0, 0)]
        [InlineData(-105, -1050)]

        public void ShouldReturnNoZeroEnding(int expected, int actual)
        {
            var result = NoZerosforHeroes.NoBoringZeros(actual);
            Assert.Equal(expected, result);
        }
    }
}
