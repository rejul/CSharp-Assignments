using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment2.Model
{
    public class Employee
    {
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public int YearsOfService { get; set; }


        public Employee()
        {
        }

        public  double CalculateBonus()
        {
            // Calculate bonus based on years of service
            //baseSalary * 0.05 * yearsOfService 

            return this.BaseSalary*0.05 * this.YearsOfService;

        }

        public double TotalSalary()
        {
            return this.BaseSalary + this.CalculateBonus();
        }

        public override string ToString()
        {
            return $"Employee Name: {Name}, Base Salary: {BaseSalary}, Years of Service: {YearsOfService}, Total Salary: {this.TotalSalary()}";
        }

    }
}
