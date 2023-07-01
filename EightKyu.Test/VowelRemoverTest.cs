using Eight.Kyuu;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class VowelRemoverTest
    {
        [Theory]
        [InlineData("hll", "hello")]

        public void ShouldReturnRemovedVowels(string expected, string input)
        {
            var result = VowelRemover.Shortcut(input);
            Assert.Equal(expected, result); 
        }
    }
}
