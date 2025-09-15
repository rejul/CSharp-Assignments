namespace ConsoleAppA
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException() { }
        public InvalidAgeException(string message) : base(message) { }
    }

    // Employee class
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Employee(string name, int age)
        {
            if (age < 18 || age > 60)
            {
                throw new InvalidAgeException("Age must be between 18 and 60.");
            }
            Name = name;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Employee Name: {Name}, Age: {Age}");
        }
    }

    // Main Program
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter Employee Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Employee Age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Employee emp = new Employee(name, age);
                emp.DisplayInfo();
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Age must be a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error: " + ex.Message);
            }
        }
    }
}
