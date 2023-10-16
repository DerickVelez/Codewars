using Seven.Kyu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKyu.Test
{
    public class ProductofLargestPairTest
    {
        [Theory]
        [InlineData(new int[] { 39, 135, 47, 275, 37, 108, 265, 457, 2, 133, 316, 330, 153, 253, 321, 411 }, 187827)]
        [InlineData(new int[] { 375, 56, 337, 466, 203 }, 174750)]

        public void ShouldReturnLargestPairProduct(int[] array, int expected)
        {
            var result = ProductofLargestPair.MaxProduct(array);
            Assert.Equal(expected, result);
        }
    }
}
