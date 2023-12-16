﻿using Eight.Kyuu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class Regexp_Basics___is_it_a_digit_Test
    {
        [Theory]
        [InlineData("",false)]
        [InlineData("0",true)]
        [InlineData(" ",false)]
        [InlineData("e1",false)]
        [InlineData("12",true)]

        public void ShouldReturnTrueifNumber(string input,  bool expected)
        {
            var result = Regexp_Basics___is_it_a_digit.Digit(input);
            Assert.Equal(expected, result);
        }

    }
}
