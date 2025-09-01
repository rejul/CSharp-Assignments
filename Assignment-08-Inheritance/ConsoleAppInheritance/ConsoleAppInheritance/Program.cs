using ConsoleAppInheritance.Model;
using System.ComponentModel;

namespace ConsoleAppInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EMPLOYEE
            Employee employeeOne = new Employee();//default constructor
            employeeOne.EmployeeId = 1001;
            employeeOne.EmployeeName = "Test";
            employeeOne.Salary = 10000;
            //parent
            Console.WriteLine("----Employee Details----");
            Console.WriteLine(employeeOne.GetDetails());


            Employee employeeTwo = new Employee(1002, "Ganga", 12345.00);//parameterized constructor
            Console.WriteLine(employeeTwo.GetDetails());
            //developer
            Developer developer = new Developer(1003, "Amal", 45000, "C#");
            Console.WriteLine(developer.GetDetails() + $"Language : {developer.ProgrammingLanguage}");
            Console.ReadKey();

            //#region UST
            //Console.WriteLine("Enter the number:");
            //int num =Convert.ToInt32(Console.ReadLine());
            //if (num % 3 == 0)
            //{
            //    Console.WriteLine("abc");
            //}
            //else if (num % 5 == 0)
            //{
            //    Console.WriteLine("def");
            //}
            //else if (num % 3 == 0 && num % 5 ==0) 
            //{
            //    Console.WriteLine("abcdef");
            //}
            //else {
            //    Console.WriteLine("Invalid number entered");
            //    Console.ReadLine();
            //#endregion
        }
    }
}
