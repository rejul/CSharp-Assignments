using System;

class Program
{
    static void Main()
    {
        //Write a program in C# which is a Menu-Driven Program 
        // to perform a simple calculation 
        #region MenuLoop
        while (true) // Loop until user chooses to exit
        {
            Console.WriteLine("\n=== Simple Calculator Menu ===");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice (1-5): ");

            string? choice = Console.ReadLine(); // Nullable type '?'

            switch (choice)
            {
                case "1":
                    PerformCalculation("Addition");
                    break;

                case "2":
                    PerformCalculation("Subtraction");
                    break;

                case "3":
                    PerformCalculation("Multiplication");
                    break;

                case "4":
                    PerformCalculation("Division");
                    break;

                case "5":
                    Console.WriteLine("Exiting... Goodbye!");
                    return; // Exit program

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        #endregion
    }

    #region PerformCalculationMethod
    static void PerformCalculation(string operation)
    {
        #region InputNumbers
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine() ?? "0");
        #endregion

        #region CalculationLogic
        double result = 0;

        switch (operation)
        {
            case "Addition":
                result = num1 + num2;
                break;
            case "Subtraction":
                result = num1 - num2;
                break;
            case "Multiplication":
                result = num1 * num2;
                break;
            case "Division":
                if (num2 != 0)
                    result = num1 / num2;
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    return;
                }
                break;
        }
        #endregion

        #region OutputResult
        Console.WriteLine($"Result of {operation}: {result}");
        #endregion
    }
    #endregion
}
