using Eight.Kyuu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class RemovingElementsTest
    {
        [Theory]
        [InlineData(new object[] { "Hello", "Hello Again" }, new object[] { "Hello", "Goodbye", "Hello Again" })]
        [InlineData(new object[] { 1, 3, 5, 7, 9 }, new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]

        public void ShouldReturnFinalElements(object[] expected, object[] elements)
        {
            var result = RemovingElements.RemoveEveryOther(elements); 
            Assert.Equal(expected, result);
        }
    }
}
