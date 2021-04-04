using System;

namespace Class
{
    partial class Student:Person
    {
        public int Grade;
        public double Payment;

        //constructor - class ile eyni adda metoddur,return type yoxdur,
        //ayriliqda chagrila bilmir-yalniz object instance alanda chagirirlir
        public Student():base("")
        {
            Console.WriteLine("Student created");
        }

        public Student(string name):this()
        {
            Name = name;
        }

        public Student(string name,string surname):this(name)
        {
            Surname = surname;
        }

        public Student(string name, string surname,int age):this(name, surname)
        {
            Age = age;
        }
    }

}
