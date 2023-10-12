using Eight.Kyuu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test.AddedTest
{
    public class GetPlanetNamebyIdTest
    {
        [Theory]
        [InlineData("Earth", 3)]
        [InlineData("Mercury", 1)]

        public void ShouldReturnPlanetName(string expected, int input)
        {
            var result = GetPlanetNamebyId.GetPlanetName(input);
            Assert.Equal(expected, result);
        }
    }
}
