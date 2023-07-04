using Eight.Kyuu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test.AddedTest
{
    public class ReversedSequenceTest
    {
        [Theory]
        [InlineData(5, new int[] { 5, 4, 3, 2, 1 })]

        public void ShouldReturnReversedArray(int n, int[] expected)
        {
            var result = ReversedSequence.ReverseSeq(n);
            Assert.Equal(expected, result);
        }
    }
}
