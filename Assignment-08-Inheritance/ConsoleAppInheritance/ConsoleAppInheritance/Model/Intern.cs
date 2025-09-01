using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritance.Model
{
    public class Intern : Employee
    {
        //fields
        public int DurationMonths { get; set; }

        //default constructor
        public Intern(int employeeId, string name, double salary, int Duration) : base(employeeId, name, salary) //base contain fields from parent
        {
            DurationMonths = Duration;
        }
    }
}
