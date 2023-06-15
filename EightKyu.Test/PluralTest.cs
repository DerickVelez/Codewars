using Eight.Kyuu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class PluralTest
    {
        [Theory]
        [InlineData(0, true)]
        [InlineData(1, false)]
        [InlineData(double.PositiveInfinity, true)]

        public void ShouldReturnTrueifPlural(double input,bool expected)
        {
            var result = Plural.PluralWords(input);
            Assert.Equal(expected, result);
        }
    }
}
