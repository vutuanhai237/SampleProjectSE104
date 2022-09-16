using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject1
{
    class Employee
    {
        public string name { get; set; }
        public double salary { get; set; }
        public Employee(string _name)
        {
            this.name = _name;
        }
        public string exportInfor()
        {
            return name + ": " + salary.ToString();
        }

        public void calculateSalary(int dayOfWork)
        {
            this.salary = dayOfWork * 100 + 50;
        }
    }
}
