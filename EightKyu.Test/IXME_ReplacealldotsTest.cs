using Eight.Kyuu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class IXME_ReplacealldotsTest
    {
        [Theory]
        [InlineData("one-two-three", "one.two.three")]
        [InlineData("no dots", "no dots")]
        [InlineData("", "")]

        public void ShouldReturnNoDots(string input, string output)
        {
            var result = FIXME_Replacealldots.ReplaceDots(output); 
            Assert.Equal(input, result);
        }
    }
}
