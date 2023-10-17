using Seven.Kyu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKyu.Test.Added
{
    public class RetutnSubstringInstanceCountTest
    {
        [Theory]
        [InlineData(2, "abcdeb", "b")]
        [InlineData(3, "ccddeeccddeecc", "cc")]

        public void ShouldReturnOccurences(int expected, string fulltext, string searchtext)
        {
            var result = ReturnSubstringInstanceCount.SubstringCount(fulltext, searchtext);
            Assert.Equal(expected, result);
        }
    }
}
