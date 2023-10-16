using Seven.Kyu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKyu.Test
{
    public class AreaOfaCircleTest
    {
        [Theory]
        [InlineData(14526.724,68)]
        [InlineData(43.2673, 5881.248)]
        [InlineData(null, null)]

        public void ShouldReturnAreaofCircle(double x, double y)
        {
            var result = AreaOfaCircle.CalculateAreaOfCircle(y);
            Assert.Equal(x, result);
        }
    
    }
}
