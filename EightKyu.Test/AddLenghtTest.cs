using Eight.Kyuu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class AddLenghtTest
    {
        [Theory]
        [InlineData(new string[] { "apple 5", "ban 3" }, "apple ban")]
        [InlineData(new string[] { "you 3", "will 4", "win 3" }, "you will win")]

        public void ShouldReturnStringWithLength(string[] expected, string input)
        {
            var result = AddLength.AddLengthInString(input);
            Assert.Equal(expected, result);
        }
    }
}
