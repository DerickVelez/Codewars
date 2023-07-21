using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu
{
    public class SetAlarm
    {
        public static bool SetAlarms(bool employed, bool vacation) => employed == true && vacation == false ? true : false;
    }
}
