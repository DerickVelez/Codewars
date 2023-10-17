using Seven.Kyu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKyu.Test.Added
{
    public class TwoNumbersArePositiveTest
    {
        [Theory]
        [InlineData(true, 2, 4, -3)]
        [InlineData(false, -14, -3, -4)]
        [InlineData(false, 4, 6, 10)]

        public void ShouldReturnTrueIfTwoNumbersArePositive(bool expected, int one, int two, int three)
        {
            var result = TwoNumbersArePositive.TwoArePositive(one, two, three);
            Assert.Equal(expected, result);
        }
    }
}
