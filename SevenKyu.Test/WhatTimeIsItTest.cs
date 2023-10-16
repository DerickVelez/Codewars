using Seven.Kyu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKyu.Test
{
    public class WhatTimeIsItTest
    {
        [Theory]
        [InlineData("23:46:47", "11:46:47PM")]
        [InlineData("22:44:45", "10:44:45PM")]

        public void ShouldReturnMilitaryTime(string expected, string input)
        {
            var result = WhatTimeIsIt.GetMilitaryTimeFromStandardTime(input); 
            
            Assert.Equal(expected, result);
        }
    }
}
