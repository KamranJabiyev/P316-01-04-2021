using System;
namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Anonimouse object
            //string name = "Cefer";
            //string surname = "Memmedzade";
            //int age = 20;

            //string name1 = "Nazim";
            //string surname1 = "Hesenov";
            //int age1 = 29;

            //anonimous object
            //var stu1 = new
            //{
            //    name = "Cefer",
            //    surname = "Memmedzade",
            //    age = 20
            //};

            //var stu2 = new
            //{
            //    name = "Nazim",
            //    surname = "Memmedzade",
            //    age = 29
            //};

            //Console.WriteLine(stu2.name+" "+stu2.surname+" "+stu2.age);
            //Console.WriteLine(stu1.name+" "+stu1.surname+" "+stu1.age);
            //Student stu1 = new Student();
            //stu1.Name = "Cefer";
            //stu1.Surname = "Memmedzade";
            //stu1.Age = 20;

            //stu1.GetInfo();
            ////instance
            //Student stu2 = new Student();
            //stu2.Name = "Nazim";
            //stu2.Surname = "Hesenov";
            //stu2.Age = 29;
            //stu2.GetInfo();
            #endregion

            Student s1 = new Student("Faiq","Abdullayev",21);
            s1.GetInfo();
            Developer developer = new Developer();
            developer.Name = "Cefer";
            Console.WriteLine(developer.Name);
        }
    }

}
