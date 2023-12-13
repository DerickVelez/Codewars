using Seven.Kyu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKyu.Test.Added
{
    public class CountConsonantsTest
    {
        [Theory]
        [InlineData(5, "Bbbbb")]
        [InlineData(7, "h^$&^#$&^elLo world")]
        [InlineData(4,"bougart")]


        public void ShouldReturnNumberofConsonants(int expected, string actual)
        {
            var result = CountConsonants.ConsonantCount(actual);
            Assert.Equal(expected, result);
        }
    }
}
