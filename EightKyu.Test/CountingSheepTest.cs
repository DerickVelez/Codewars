using Eight.Kyuu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class CountingSheepTest
    {
        [Theory]
        [InlineData(2, new bool[] { true, false, true, true, false, true, true, false, true })]
        [InlineData(6, new bool[] { true, true, true, true, true, true, true, true, true })]

        public void ShouldReturnNumberofSheep(int expected, bool[] actual)
        {
            var result = CountingSheep.CountSheeps(actual); 
            Assert.Equal(expected, result);
        }
    }
}
