using Seven.Kyu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKyu.Test.Added
{
    public class JasonCasingStringTest
    {
        [Theory]
        [InlineData("Most Trees Are Blue", "most trees are blue")]

        public void ShouldReturnTitleCasedString(string expected, string actual)
        {
            var result = actual.ToJadenCase();
            Assert.Equal(expected, result);
        }
    }
}
