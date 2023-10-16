using Seven.Kyu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKyu.Test
{
    public class CircleAreaInsideSquareTest
    {
        [Theory]
        [InlineData(7.06858347, 9)]
        [InlineData(15.70796327, 20)]

        public void ShouldReturnAreaOfCircle(double expected, double actual)
        {
            var result = CircleAreaInsideSquare.SquareAreaToCircle(actual);
            Assert.Equal(expected, result);
        }
    }
}
