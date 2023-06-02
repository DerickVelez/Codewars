using Eight.Kyuu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class CountthenumberofcubeswithpaintonTest
    {
        [Theory]
        [InlineData(0, 1)]
        [InlineData(16,1538)]

        public void ShouldReturnnumberofCubes(int result,int expected)
        {
            var output = Countthenumberofcubeswithpainton.CountSquares(result);
            Assert.Equal(expected, output);

        }
    }
}
