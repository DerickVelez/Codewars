﻿using Seven.Kyu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKyu.Test.Added
{
    public class OddorEvenTest
    {
        [Theory]
        [InlineData("even", new int[] { 0 })]
        [InlineData("even", new int[] { })]
        [InlineData("odd", new int[] { 1023, 1, 3 })]
        [InlineData("odd", new int[] { 1027, 1, 3 })]
        [InlineData("even", new int[] { 2, 4, 6, 8, 10 })]
        [InlineData("odd", new int[] {2,4,8,12})]
        [InlineData("even", new int[] { 3, 4, 8, 12 })]


        public void ShouldReturnOddorEven(string expected, int[] input)
        {
            var result = OddorEven.OddOrEven(input);
            Assert.Equal(expected, result);
        }

    }
}
