using Eight.Kyuu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test.AddedTest
{
    public class ReturnToSanityTest
    {
        [Fact]

        public void ShouldReturnSanity()
        {
            var result = new Dictionary<string, string> { { "sanity", "hello" } };
            var output = ReturnToSanity.Mystery();
            Assert.Equal(result, output);

        }
    }
}
