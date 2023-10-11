using Eight.Kyuu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test.AddedTest
{
    public class BasicMathematicalOperationsTest
    {
        [Theory]
        [InlineData(11, '+', 4, 7)]
        [InlineData(-3, '-', 15, 18)]
        [InlineData(25, '*', 5, 5)]

        public void ShouldReturnResult(int expected, char operation, int input1, int input2)
        {
            var result = BasicMathematicalOperations.basicOp(operation, input1, input2);
            Assert.Equal(expected, result);
        }
    }
}
