using Eight.Kyuu;
using Eight.Kyuu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test
{
    public class How_old_will_I_be_in_2099_Test
    {
        [Theory]
        [InlineData("You are 4 years old.", 2012, 2016)]
        [InlineData("You are 27 years old.", 1989, 2016)]
        [InlineData("You are 90 years old.", 2000, 2090)]
        [InlineData("You will be born , 510 years.", 2010, 1500)]

        public void ShoulReturnYearOldNow(string expected, int birth, int yearTo)
        {
            var result = How_old_will_I_be_in_2099.CalculateAge(birth, yearTo); 
            Assert.Equal(expected, result);
        }
    }
}
