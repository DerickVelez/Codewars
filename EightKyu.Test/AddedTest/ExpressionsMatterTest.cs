using Eight.Kyuu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test.AddedTest
{
    public class ExpressionsMatterTest
    {
        [Theory]
        [InlineData(9, 1, 2, 3)]

        public void ShouldReturnMax(int expected, int a, int b, int c)
        {
            var result = ExpressionsMatter.ExpressionsMatterExecution(a, b, c);
            Assert.Equal(expected, result);
        }
    }
}
