using ConsoleAppCompany.Model;

namespace ConsoleAppCompany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter employee name");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter salary");
            double Salary = Convert.ToDouble(Console.ReadLine());

            //logic check for specific employee
            Console.WriteLine("Enter employee type (Emp/Dev/Man)");
            string empType = Console.ReadLine();

            //declare a null object
            Employee employee = null;

            //emp/ EMP // IgnoreCase sensitive
            //based on empType, need to create respective object
            if (empType.Equals("Emp", StringComparison.OrdinalIgnoreCase))
            {
                employee = new Employee(Name, Salary);
            }
            else if (empType.Equals("Dev", StringComparison.OrdinalIgnoreCase))
            {
                employee = new Developer(Name, Salary);
            }
            else if (empType.Equals("Man"))
            {
                employee = new Manager(Name, Salary);
            }
            else
            {
                Console.WriteLine("Invalid operation.....!");
            }
            Console.WriteLine($"{employee.Name} Bonus: {employee.CalculateBonus()}");
             Console.ReadKey();
        }
    }
}
