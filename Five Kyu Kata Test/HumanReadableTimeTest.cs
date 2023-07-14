using Five_Kyu_Kata;

namespace Five_Kyu_Kata_Test
{
    public  class HumanReadableTimeTest
    {
        [Theory]
        [InlineData("12:34:56", 45296)]
        [InlineData("24:00:00" ,86400)]

        public  void ShouldReturnHumanReadableTime(string expected, int input)
        {
            var result = HumanReadableTime.GetReadableTime(input);

            Assert.Equal(expected, result); 
        }
    }
}