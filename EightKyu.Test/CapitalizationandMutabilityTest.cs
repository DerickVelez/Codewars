using Eight.Kyuu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class CapitalizationandMutabilityTest
    {
        [Theory]
        [InlineData("Word", "word")]

        public void ShouldReturnTitleCase(string expected, string input)
        {
            var result = CapitallizationandMutability.CapitalizeWord(input);

            Assert.Equal(expected, result);
        }
    }
}
