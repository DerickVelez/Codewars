using Seven.Kyu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKyu.Test.Added
{
    public class SortArraybyStringLengthTest
    {
        [Theory]
        [InlineData(new string[] { "I", "To", "Beg", "Life" }, new string[] { "Beg", "Life", "I", "To" })]

        public void ShouldReturnSortedArray(string[] expected, string[] input)
        {
            var result = SortArraybyStringLength.SortByLength(input);

            Assert.Equal(expected, result);
        }

    }

}
