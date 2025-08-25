using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritance.Model
{
    
    public class Developer : Employee //employee object created at employee.cs  is given here as "Employee"
    {
        //FIELDS
        public string ProgrammingLanguage { get; set; }

        //default constructor
        public Developer(int employeeId, string name, double salary,string ProgLang) : base(employeeId,name,salary) //base contain fields from parent
        {
            ProgrammingLanguage = ProgLang;
        }
        //get details
        //GetDetails of Employee
        public override string GetDetails()
        {
            //return $"ID:{EmployeeId},Name:{EmployeeName},Salary:{Salary}";
            StringBuilder sb = new StringBuilder();
            sb.Append("ID:").Append(EmployeeId)
                .Append(",Name:").Append(EmployeeName)
                .Append(",Salary:").Append(Salary)
                .Append("Language").Append(ProgrammingLanguage);

            return sb.ToString();
        }

    }
}
