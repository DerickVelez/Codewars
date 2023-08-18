﻿using Eight.Kyuu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class DoubleCharTest
    {
        [Theory]
        [InlineData("abcd", "aabbccdd")]
        [InlineData("Adidas", "AAddiiddaass")]

        public void ShouldReturnDoubleCharacters(string input, string expected)
        {
            var result = DoubleChar.CharChar(input);
            Assert.Equal(expected, result);
        }

    }
}
