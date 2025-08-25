using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Employee.Model
{
    public class Employee
    {
        //Design a class Employee-no, Name, Designation, Basic Pay. Define a 
        // derived class Executive whose Basic_pay is more than Rs.10,000. 
        public int? EmpNo { get; set; }
        public string? Name { get; set; }
        public string? Designation { get; set; }
        public decimal? BasicPay { get; set; }

        public Employee()
        {
            EmpNo = null;
            Name = null;
            Designation = null;
            BasicPay = null;

        }
        public Employee(int empNo, string name, string designation, decimal basicPay)
        {
            EmpNo = empNo;
            Name = name;
            Designation = designation;
            BasicPay = basicPay;
        }


        public virtual void Display()
        {
            Console.WriteLine("___Employee Details___");
            Console.WriteLine($"Employee Number: {EmpNo}");
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Employee Designation: {Designation}");
            Console.WriteLine($"Employee Basic Pay: {BasicPay}");

        }

    }

    public class Executive : Employee

    {
        public Executive() : base()
        {
        }
        public Executive(int empNo, string name, decimal basicPay) : base( empNo,  name, "Executive",  basicPay)
        {
            if (basicPay <= 10000)
            {
                Console.WriteLine("Basic pay should be greater than 10000");
               
            }
        }
        //basic pay more than 10000
        public override void Display() {
            try
            {
                Console.WriteLine(
                    "___Executive Details___");
                Console.WriteLine($"Employee Number: {EmpNo}");
                Console.WriteLine($"Employee Name: {Name}");
                Console.WriteLine($"Employee Designation: {Designation}");
                Console.WriteLine($"Employee Basic Pay: {BasicPay}");

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
        }
    }
}
