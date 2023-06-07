using Eight.Kyuu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class ArrayPlusArrayTest
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, 21)]


        public void ShouldReturnSum(int[] arr1, int[] arr2, int expected)
        {
            var result = ArrayPlusArray.SumofArray(arr1, arr2);

            Assert.Equal(expected, result);
        }
    }
}

