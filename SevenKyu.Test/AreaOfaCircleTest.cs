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
        [InlineData(14526.724430199203,68)]
        [InlineData(108664793.45706661, 5881.248)]
        

        public void ShouldReturnAreaofCircle(double x, double y)
        {
            var result = AreaOfaCircle.CalculateAreaOfCircle(y);
            Assert.Equal(x, result);
        }
    
    }
}
