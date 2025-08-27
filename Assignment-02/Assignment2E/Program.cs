using System;

class Program
{
    static void Main()
    { 
        #region AreaCalculator
        //Write a program in C# which is a Menu-Driven Program 
        // to compute the area of the various geometrical shape

        while (true) // Loop until user chooses to exit
        {
            Console.WriteLine("\n=== Area Calculator Menu ===");
            Console.WriteLine("1. Area of Circle");
            Console.WriteLine("2. Area of Rectangle");
            Console.WriteLine("3. Area of Triangle");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice (1-4): ");

            string? choice = Console.ReadLine(); //Nullable type '?'

            switch (choice)
            {
                case "1":
                    CalculateCircleArea();
                    break;

                case "2":
                    CalculateRectangleArea();
                    break;

                case "3":
                    CalculateTriangleArea();
                    break;

                case "4":
                    Console.WriteLine("Exiting... Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
#endregion AreaCalculator


    #region CalculateCircleArea
    static void CalculateCircleArea()
    {
        Console.Write("Enter radius: ");
        double radius = double.Parse(Console.ReadLine() ?? "0");
        double area = Math.PI * radius * radius;
        Console.WriteLine($"Area of Circle = {area:F2}");
    }
    #endregion 


    #region CalculateRectangleArea

    static void CalculateRectangleArea()
    {
        Console.Write("Enter length: ");
        double length = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter width: ");
        double width = double.Parse(Console.ReadLine() ?? "0");
        double area = length * width;
        Console.WriteLine($"Area of Rectangle = {area:F2}");
    }
    #endregion

    #region CalculateTriangleArea
    static void CalculateTriangleArea()
    {
        Console.Write("Enter base: ");
        double baseVal = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter height: ");
        double height = double.Parse(Console.ReadLine() ?? "0");
        double area = 0.5 * baseVal * height;
        Console.WriteLine($"Area of Triangle = {area:F2}");
    }
    #endregion
}
