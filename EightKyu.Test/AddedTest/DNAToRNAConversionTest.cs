using Eight.Kyuu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test.AddedTest
{
    public class DNAToRNAConversionTest
    {
        [Theory]
        [InlineData("UUUU", "TTTT")]
        [InlineData("GACCGCCGCC", "GACCGCCGCC")]

        public void ShouldReturnConvertedString(string expected, string input)
        {
            var result = DNAToRNAConversion.dnaToRna(input);
            Assert.Equal(expected, result);
        }
    }
}
