using Eight.Kyuu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class SimpleMultiplicationTest
    {
        [Theory]
        [InlineData(64,8)]
        [InlineData(32,4)]
        
        public void ShouldReturnMultiplication( int expected, int actual)
        {
            var result = SimbpleMultiplication.Multiply(actual);
            Assert.Equal(expected, result);
        }
    }
}
