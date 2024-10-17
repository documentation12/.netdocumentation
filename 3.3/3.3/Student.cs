using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    internal class Student
    {
        private string Name;
        public int Grade { get; set; }

        public Student(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }

        public string Greeting()
        {
            return $"Hi i am {Name} and my {Grade} ";
        }
    }
}
