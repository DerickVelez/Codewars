using Seven.Kyu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKyu.Test
{
    public class ArrayElementParityTest
    {
        [Theory]
        [InlineData(3, new int[] { 1, -1, 2, -2, 3 })]
        [InlineData(-38, new int[] { -110, 110, -38, -38, -62, 62, -38, -38, -38 })]
    
        public void ShouldReturnUniqueInt(int expected, int[] actual)
        {
            var result = ArrayElementParity.Solve(actual);
            Assert.Equal(expected, result);
        }
    }
}
