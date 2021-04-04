using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    //inheretance
    class Developer:Person
    {
        public int Experience;
        public string[] Languages;

        public Developer()
        {

        }

        public override void GetInfo()
        {
            Console.WriteLine($"{Name} {Experience}");
        }
    }
}
