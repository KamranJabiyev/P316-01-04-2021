using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class Person
    {
        public string Name;
        public string Surname;
        public int Age;
        public Person(string s)
        {
            Console.WriteLine("Person created");
        }
        public Person()
        {

        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"{Name} {Surname} {Age}");
        }
    }
}
