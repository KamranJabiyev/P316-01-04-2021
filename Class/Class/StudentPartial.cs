using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    partial class Student
    {
        public string GetFullname()
        {
            return $"{Name} {Surname}";
        }

        //polymorphisim
        public override void GetInfo()
        {
            base.GetInfo();
        }
    }
}
