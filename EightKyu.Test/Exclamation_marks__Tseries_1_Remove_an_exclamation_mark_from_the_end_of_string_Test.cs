﻿using Eight.Kyuu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class Exclamation_marks__Tseries_1_Remove_an_exclamation_mark_from_the_end_of_string_Test
    {
        [Theory]
        [InlineData("Hi", "Hi!")]
        [InlineData("Hi!!", "Hi!!!")]
        [InlineData("Good Morning!", "Good Morning")]
        [InlineData("Good Evening!", "Good Evening")]
        [InlineData("Merry!!!!Christmas!", "Merry!!!!Christmas")]
        [InlineData("Happy New Year!", "Happy New Year")]
        [InlineData("Derick!", "Derick")]




        public void ShouldReturnReducedString(string expected, string actual)
        {
            var result = Exclamation_marks_series_1_Remove_an_exclamation_mark_from_the_end_of_string.Remove(expected);
            Assert.Equal(actual, result);
        }
    }
}