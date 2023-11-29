using Eight.Kyuu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class String_Templates___Bug_Fixing__5_Test
    {
        [Theory]
        [InlineData("I like Cheese, Milk, Chocolate!", new string[] { "Cheese", "Milk", "Chocolate" })]
        [InlineData("I like Cheese, Milk!", new string[] { "Cheese", "Milk" })]

        public void ShouldReturnCorrectedString(string expected, string[] actual)
        {
            var result = String_Templates___Bug_Fixing__5.buildString(actual); 
            Assert.Equal(expected, result);
        }
    }
}
