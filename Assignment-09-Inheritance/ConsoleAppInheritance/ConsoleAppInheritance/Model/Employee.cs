using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritance.Model
{       
    //base employee
    public class Employee
    {
        //fields
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public double Salary { get; set; }

        //default constructor
        public Employee()
        {
            
        }
        //parametrized constructor
        public Employee(int employeeId, string employeeName, double salary)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            Salary = salary;
        }
        //get details of employee
        public virtual string GetDetails()
        {
            //return $"ID:{EmployeeId},Name:{EmployeeName},Salary:{Salary}";
            StringBuilder sb = new StringBuilder();
            sb.Append("ID:").Append(EmployeeId)
                .Append(",Name:").Append(EmployeeName)
                .Append(",Salary:").Append(Salary);

            return sb.ToString();
        }


    }
}
