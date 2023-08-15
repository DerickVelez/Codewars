using Eight.Kyuu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class WelcomeToTheCityTest
    {
        [Theory]
        [InlineData("Hello, John Smith! Welcome to Phoenix, Arizona!", new string[] { "John", "Smith" }, "Phoenix", "Arizona")]
        [InlineData("Hello, Franklin Delano Roosevelt! Welcome to Chicago, Illinois!", new string[] { "Franklin", "Delano", "Roosevelt" },"Chicago", "Illinois")]

        public void ShouldReturnConvertedString(string expected, string[] a, string b, string c)
        {
            var result = WelcomeToTheCity.SayHello(a, b, c);
            Assert.Equal(expected, result);
        }
    }
}
