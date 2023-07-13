using Six_Kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixKyu.Test
{
    public class FindthePartyOutlierTest
    {
        [Theory]
        [InlineData(206847684 , new int[] { 206847684, 1056521, 7, 17, 1901, 21104421, 7, 1, 35521, 1, 7781 })]
        [InlineData(3 ,new int[] { 2, 6, 8, -10, 3 })]
        
        public void ShouldReturnOutlier(int expected, int[] outlier)
        {
            var result = FindthePartyOutlier.Find(outlier);
            Assert.Equal(expected, result); 
        }

    }
}
