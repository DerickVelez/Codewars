using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu.Added
{
    public class Person
    {
        private string name;
        private int age;
        public string Info => $"{name}s age is {age}";

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
