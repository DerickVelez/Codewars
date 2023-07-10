using Eight.Kyuu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test.AddedTest
{
    public class ConvertStringtoArrayTest
    {
        [Theory]
        [InlineData(new string[] { "Robin", "Singh" }, "Robin Singh")]


        public void ShouldReturnArray(string[] expected, string input)
        {
            var result = ConvertStringtoArray.StringToArray(input);
            Assert.Equal(expected, result);
        }
    }
}
