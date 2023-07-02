using Seven.Kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKyu.Test
{
    public  class LengthofTwoValuesTest
    {
        [Theory]
        [InlineData(5, true, false, new object[] { true, false, true, false, true })]


        public void ShouldReturnnumberofoccurence(int n, object firstValue, object secondValue, object[] expected)
        {
       
            var result = LengthofTwoValues.AlternateObjectArray(n, firstValue, secondValue);
            Assert.Equal( expected, result);
        }
    }
}
