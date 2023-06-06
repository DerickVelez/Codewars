using Eight.Kyuu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public static class KeepHydratedTest
    {
       [Theory]
       [InlineData(1.4, 0)]

       public static void ShouldReturnLiters(double output,int expected )
        {
            var result = KeepHydrated.Litres(output);

            Assert.Equal(expected, result);
        }
    }
}

