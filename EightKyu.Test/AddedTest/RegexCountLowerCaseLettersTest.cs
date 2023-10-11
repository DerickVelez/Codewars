using Eight.Kyuu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test.AddedTest
{
    public class RegexCountLowerCaseLettersTest
    {
        [Theory]
        [InlineData(3, "abc")]
        [InlineData(3, "abcABC123!@€£#$%^&*()_-+=}{[]|\':;?/>.<,~")]
        [InlineData(26, "abcdefghijklmnopqrstuvwxyz")]

        public void ShouldReturnNumofLowerCase(int expected, string text)
        {
            var result = RegexCountLowerCaseeLetters.LowercaseCountCheck(text);
            Assert.Equal(expected, result);
        }
    }
}
