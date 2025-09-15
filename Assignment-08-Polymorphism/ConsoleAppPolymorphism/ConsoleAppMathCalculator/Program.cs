using System;
using ConsoleAppMathCalculator.Model;

namespace ConsoleAppMathCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create calculator object
            Model.Math calculator = new Basic();

            // Get numbers from user
            Console.WriteLine("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            // Menu driven choice
            Console.WriteLine("Choose operation:\n1. Add\n2. Subtract\n3. Multiply\n4. Divide");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result = 0;
            string operation = "";

            switch (choice)
            {
                case 1:
                    result = calculator.Add(num1, num2);
                    operation = "addition";
                    break;
                case 2:
                    result = calculator.Subtract(num1, num2);
                    operation = "subtraction";
                    break;
                case 3:
                    result = calculator.Multiply(num1, num2);
                    operation = "multiplication";
                    break;
                case 4:
                    result = calculator.Divide(num1, num2);
                    operation = "division";
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    return;
            }

            // Display result
            calculator.DisplayResult(result, operation);

            Console.ReadKey();
        }
    }
}
