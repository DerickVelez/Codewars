using Seven.Kyu;
using Seven.Kyu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKyu.Test
{
    public class Count_the_divisors_of_a_number_Test
    {
        [Theory]
        [InlineData(1,1)]
        [InlineData(4,10)]
        [InlineData(8,54)]
        [InlineData(2,2)]
        
        public void ShouldReturnNumberofDivisor(int expected, int n)
        {
            var result = Count_the_divisors_of_a_number.Divisors(n);
            Assert.Equal(expected, result);
        }
    }
}
