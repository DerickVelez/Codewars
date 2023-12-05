using Eight.Kyuu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EightKyu.Test
{
    public class Age_Range_Compatibility_Equation_Test
    {
        [Theory]
        [InlineData("15-20",17)]
        [InlineData("20-40", 27)]
        [InlineData("4-5",5)]
        [InlineData("3-6",6)]
    

        public void ShouldReturnRange(string expected, int given)
        {
            var result = Age_Range_Compatibility_Equation.DatingRange(given);
            Assert.Equal(expected, result);
        }
    }
}
