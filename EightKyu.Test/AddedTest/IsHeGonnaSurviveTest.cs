using Eight.Kyuu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test.AddedTest
{
    public class IsHeGonnaSurviveTest
    {
        [Theory]
        [InlineData(true, 100, 40)]
        [InlineData(true, 10, 5)]

        public void ShouldReturnTrueIfHeSurvive(bool expected, int bullets, int dragons)
        {
            var result = IsHeGonnaSurvive.Hero(bullets, dragons);
            Assert.Equal(expected, result);
        }
    }
}
