using Eight.Kyuu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test.AddedTest
{
    public class WelcomeTest
    {
        [Theory]
        [InlineData("Welcome", "english")]

        public void ShouldReturnTranslation(string expected, string output)
        {
            var result = Welcome.Greet(output);
            Assert.Equal(expected, result);
        }
    }
}
