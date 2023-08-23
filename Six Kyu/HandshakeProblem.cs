using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six_Kyu
{
    public class HandshakeProblem
    {
        public static int GetParticipants(int handshakes) => handshakes == 0 ? 0 : (int)Math.Round(Math.Sqrt(handshakes * 2)) + 1;
    }
}
