using Seven.Kyu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKyu.Test.Added
{
    public class GettheMiddleCharacterTest
    {
        [Theory]
        [InlineData("testing", "t")]

        public void ShouldReturnMiddleLetters(string text, string expected)
        {
            var result = GettheMiddleCharacter.GetMiddle(text);
            Assert.Equal(expected, result);
        }
    }
}
