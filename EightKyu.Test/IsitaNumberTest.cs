using Eight.Kyuu;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class IsitaNumberTest
    {
        [Theory]
        [InlineData("234",true)]
        [InlineData(";askdf",false)]

        public void ShouldReturnTrueIfNumber(string input, bool expected)
        {
            var result = IsItaNumber.IsDigit(input);
            Assert.Equal(expected, result);
        }
    }
}
