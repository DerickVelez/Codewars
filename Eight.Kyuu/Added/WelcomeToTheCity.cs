using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu.Added
{
    public class WelcomeToTheCity
    {
        public static string SayHello(string[] name, string city, string state)
        {
            return $"Hello, {string.Join(" ", name)}! Welcome to {city}, {state}!";
        }
    }
}
