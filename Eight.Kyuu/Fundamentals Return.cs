using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu
{
    using System;
public static class Kata
    {
        public static int Add(int a, int b)
        {
            var result = a + b;
            return result;
        }

        public static int Multiply(int a, int b)
        {
            var result = a * b;
            return result;
        }

        public static int Divide(int a, int b)
        {
            var result = a / b;
            return result;
        }

        public static int Mod(int a, int b)
        {
            var result = a % b;
            return result;
        }

        public static int Exponent(int a, int b)
        {
            var result = Math.Pow(a, b);
            return (int)result;
        }

        public static int Subt(int a, int b)
        {
            var result = a - b;
            return result;
        }

    }
}

