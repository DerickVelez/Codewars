using Seven.Kyu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKyu.Test
{
    public class HowmanyurinalsareFreeTest
    {
        [Theory]
        [InlineData(3, "00000")]
        [InlineData(0, "1001")]
        [InlineData(-1, "101100001")]

        public void ShouldReturnNumberofFreeToilets(int expected, string actual)
        {
            var result = HowmanyurinalsareFree.GetFreeUrinals(actual);
            Assert.Equal(expected, result);
        }
    }
}
