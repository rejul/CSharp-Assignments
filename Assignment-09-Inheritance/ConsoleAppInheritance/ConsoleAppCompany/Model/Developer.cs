using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCompany.Model
{
    public class Developer : Employee
    {
        public Developer(string name,double salary) : base(name,salary)
        {
            
        }
        //method
        public override double CalculateBonus()
        {
            return Salary * 0.10;
        }
    }
}
