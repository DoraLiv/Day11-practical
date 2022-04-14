using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_class
{
    internal class Student
    {
        private string Name;
        private int Age;
        private string School;

        public Student()
        {
            Name = "Unknown";
            Age = 0;
            School = "School unknown";
        }

        public Student(string name, int age, string school)
        {
            Name = name;
            Age = age;
            School = school;
        }


        public void PrintInfo()
        {
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Student Age: {Age}");
            Console.WriteLine($"Student school: {School}");
        }
    }


}
