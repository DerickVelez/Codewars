using Eight.Kyuu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test.AddedTest
{
    public class EvenOrOddTest
    {
        [Theory]
        [InlineData("Even", 2)]
        [InlineData("Odd", 3)]
        [InlineData("Odd", -1)]

        public void ShouldReturnIfEvenOrOdd(string expected, int input)
        {
            var result = EvenOrOdd.EvenOrOddmethod(input);
            Assert.Equal(expected, result);
        }
    }
}
