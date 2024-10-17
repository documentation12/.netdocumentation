using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    public class Employee
    {
        private string employeeName;
        public int Salary { get; set; }
        public Employee(string name, int salary)
        {
            this.employeeName = name;
            this.Salary = salary;
        }

        public void Displayinfo()
        {
            Console.WriteLine($"hi, i am {employeeName} and i earn {Salary} per year");
        }
        
       


    }
}
