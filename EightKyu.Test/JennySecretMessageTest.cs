using Eight.Kyuu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class JennySecretMessageTest
    {
        [Theory]
        [InlineData("Hello, Jane!", "Jane")]
        [InlineData("Hello, my love!", "Johnny")]

        public void ShouldReturnSecretMessage(string expected, string actual)
        {
            var result = JennySecretMessage.greet(actual); 
            Assert.Equal(expected, result);
        }
    }
}
