﻿using Seven.Kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKyu.Test
{
    public class VowelCountTest
    {
        [Theory]
        [InlineData(5, "abracadabra")]
        [InlineData(0,"")]
        [InlineData(4, "pear tree")]
        [InlineData(13, "o a kak ushakov lil vo kashu kakao")]

        public void ShouldReturnNumberOfVowels(int expected, string input)
        {
            var result = VowelCount.GetVowelCount(input);
            Assert.Equal(expected, result);
        }
    }
}