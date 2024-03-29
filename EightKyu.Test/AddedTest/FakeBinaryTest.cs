﻿using Eight.Kyuu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test.AddedTest
{
    public class FakeBinaryTest
    {
        [Theory]
        [InlineData("00000000000000000", "01011110001100111")]
        [InlineData("011011110000101010000011011", "366058562030849490134388085")]
        [InlineData("101000111101101", "509321967506747")]

        public void ShouldReturnFakeBinary(string expected, string input)
        {
            var result = FakeBinary.FakeBin(input);
            Assert.Equal(expected, result);
        }
    }
}
