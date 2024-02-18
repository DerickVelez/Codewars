using Seven.Kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKyu.Test
{
    public class Shortest_Word_Test
    {
        [Theory]
        [InlineData(3, "bitcoin take over the world maybe who knows perhaps")]
        [InlineData(2, "Let's travel abroad shall we")]
        [InlineData(2, " shall we")]
        [InlineData(1, " I shall we")]
        public void ReturnShortestWordNum(int expected,  string word)
        {
            var result = Shortest_Word.FindShort(word);
            Assert.Equal(expected, result);
        }
    }
}
