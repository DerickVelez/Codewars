﻿using Eight.Kyuu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test.AddedTest
{
    public class ConvertaNumberToaStringTest
    {
        [Theory]
        [InlineData("67", 67)]
        [InlineData("23",23)]
        [InlineData("1", 1)]
    
        public void ShouldReturnStringFormat(string expected, int actual)
        {
            var result = ConvertaNumberToaString.NumberToString(actual);
            Assert.Equal(expected, result);
        }
    }
}
