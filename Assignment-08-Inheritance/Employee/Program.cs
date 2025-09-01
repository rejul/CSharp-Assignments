using Employee.Model;

namespace Employee
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Design a class Employee-no, Name, Designation, Basic Pay. Define a 
            // derived class Executive whose Basic_pay is more than Rs.10,000. 
            
           
            Console.WriteLine("Enter the Employee Details");
            Console.Write("Employee Number: ");
            int EmpNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Employee Name: ");
            string Name = Console.ReadLine();
            Console.Write("Employee Basic Pay: ");
            decimal BasicPay = Convert.ToDecimal(Console.ReadLine());

            Executive exec = new Executive(EmpNo, Name, BasicPay);


            exec.Display();
        }
    }
}
