namespace ClassAssignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            Model.Employee emp = new Model.Employee();
            Console.WriteLine("Enter Employee Name:");
            emp.Name = Console.ReadLine();
            Console.WriteLine("Enter Base Salary:");
            emp.BaseSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Years of Service:");
            emp.YearsOfService = Convert.ToInt32(Console.ReadLine());

            //Output
            Console.WriteLine(emp);
        }
    }
}
