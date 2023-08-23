using Six_Kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixKyu.Test
{
    public class HandShakeProblemTest
    {
        [Theory]
        [InlineData(0,0)]
        [InlineData(2,1)]
        [InlineData(3,3)]
        [InlineData(4,6)]
        [InlineData(5,7)]

        public void ShouldReturnNumberofPeople(int expected, int handshake)
        {
            var result = HandshakeProblem.GetParticipants(handshake);
            Assert.Equal(expected, result);
        }
    }
}
