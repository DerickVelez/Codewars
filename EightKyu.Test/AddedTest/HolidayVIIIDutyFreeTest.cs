using Eight.Kyuu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test.AddedTest
{
    public class HolidayVIIIDutyFreeTest
    {
        [Theory]
        [InlineData(357, 24, 35, 3000)]
        [InlineData(294, 17, 10, 500)]

        public void ShouldReturnDiscount(int expected, int normPrice, int Discount, int hol)
        {
            var result = HolidayVIIIDutyFree.DutyFree(normPrice, Discount, hol);
            Assert.Equal(expected, result);
        }
    }
}
