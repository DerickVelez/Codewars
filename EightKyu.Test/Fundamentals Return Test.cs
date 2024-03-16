using Eight.Kyuu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class Fundamentals_Return_Test
    {
        [Theory]
        [InlineData(12,5,7)]

        public void ShouldReturnREsult(int expected, int a, int b)
        {
            var result = Kata.Add( a, b);
            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData(35,5,7)]

        public void ShouldMultiplication(int expected, int a, int b)
        {
            var result = Kata.Multiply(a, b);
            Assert.Equal(expected, result);

        }
    }
}
