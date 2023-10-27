using Eight.Kyuu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EightKyu.Test
{
    public class Difference_of_Volumes_of_Cuboids_Test
    {
        [Theory]
        [InlineData( new int[] { 3, 2, 5 }, new int[] { 1, 4, 4 },14)]
        [InlineData(new int[] {9, 7, 2}, new int[] { 5, 2, 2 },106)]
        [InlineData(new int[] { 4, 4, 7 }, new int[] { 3, 9, 3 }, 31)]


        public void ShouldReturnDifferenceofCuboids(int[] arrA, int[] arrB, int expected)
        {
            var result = Difference_of_Volumes_of_Cuboids.FindDifference(arrA, arrB);
            Assert.Equal(expected, result);
        }
    }
}
