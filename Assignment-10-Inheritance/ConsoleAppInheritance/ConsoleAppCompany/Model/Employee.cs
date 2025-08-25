using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCompany.Model
{
    public class Employee
    {
        //fields
        public string Name { get; set; }
        public double Salary { get; set; }

        //default constructor
        public Employee()
        {
            
        }

        //parametrized constructor
        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public virtual double CalculateBonus()
        {
            return Salary * 0.05;//default 5%
        }
    }
}
