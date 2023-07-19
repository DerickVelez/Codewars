using Six_Kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixKyu.Test
{
    public class TriangleNumberCheckTest
    {
        [Theory]
        [InlineData(true,312537501)]
        [InlineData(true,61721605)]
        [InlineData(true, 0)]

        public void ShouldReturnTrueIfTriangle(bool expected, int triangleNumber)
        {
            var result = TriangleNumberCheck.isTriangleNumber(triangleNumber);
           Assert.Equal(expected,result);
        }
    }
}
