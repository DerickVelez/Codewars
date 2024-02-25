using Seven.Kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKyu.Test
{
    public class Is_this_a_triangle_Test
    {
        [Theory]
        [InlineData(true,5, 7, 10)]
        [InlineData(false, 1, 2, -3)]
        [InlineData(false, 1, 2, 5)]
        [InlineData(false, 1, 2, 7)]
        [InlineData(false,1,1,1)]


        public void ShouldReturnTrueIfTriangle(bool expected, int a, int b, int c)
        {
            var result = Is_this_a_triangle.IsTriangle(a, b, c);
            Assert.Equal(expected, result);
        }
    }
}
