using Seven.Kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKyu.Test
{
    public class Calculate_Total_Meal_Test
    {
        [Theory]
        [InlineData(5.75, 5.00, 5, 10)]
        [InlineData(45.10, 36.97, 7, 15)]
       

        public void ShouldReturnTotalFee(double expected, double subtotal, int tax, int tip)
        {
            var result = Calculate_Total_Meal.CalculateTotal(subtotal, tax, tip);
            Assert.Equal(expected, result);
        }
    }
}
