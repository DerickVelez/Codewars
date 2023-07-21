using System.Diagnostics.SymbolStore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eight.Kyuu;

namespace EightKyu.Test
{
    public class SetAlarmTest
    {
        [Theory]
        [InlineData(true,true,false)]
        [InlineData(false,false,false)]

        public void ShouldReturnTrueIfOnVacation(bool expected, bool employed, bool vacation)
        {
            var result = SetAlarm.SetAlarms(employed, vacation);
            Assert.Equal(expected,result);
        }
    }
}
