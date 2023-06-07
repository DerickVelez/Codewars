using Seven.Kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKyu.Test
{
    public class CatsAndShelvesTest
    {
        [Theory]
        [InlineData (1, 5, 2)]
        [InlineData(2, 4, 2)]

        public void ShouldReturnSteps(int start,int finish,int expected)
        {
            var result = CatsAndShelves.Cats(start, finish);
            Assert.Equal(expected,result);
        }
    }
}
