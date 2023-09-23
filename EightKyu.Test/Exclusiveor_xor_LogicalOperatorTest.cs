using Eight.Kyuu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class Exclusiveor_xor_LogicalOperatorTest
    {
        [Theory]
        [InlineData(false, false, false)]
        [InlineData(true, true, false)]

        public void ShouldReturnTrueIfhasTrue(bool expected, bool a, bool b)
        {
            var result = Exclusiveor_xor_LogicalOperator.Xor(a, b);
            Assert.Equal(expected, result);
        }
    }
}
