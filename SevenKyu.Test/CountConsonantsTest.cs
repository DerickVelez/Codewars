using Seven.Kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKyu.Test
{
   public class CountConsonantsTest
    {
        [Theory]
        [InlineData(5, "Bbbbb")]
        [InlineData(7, "h^$&^#$&^elLo world")]

        public void ShouldReturnNumberofConsonants(int expected,  string actual)
        {
            var result = CountConsonants.ConsonantCount(actual);
            Assert.Equal(expected, result);
        }
    }
}
