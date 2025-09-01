using System;

namespace StrongNumber
{
    internal class Program
    {
        /// <summary>
        /// Write a C# program to find Strong Numbers within a range of numbers.
        /// </summary>
  
        
        //Strong number is when factorial of each digit of a number is equal to the number itself.

        // Method to calculate factorial of a digit
        static int Factorial(int num)
        {
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            return fact;
        }

        // Method to check if a number is Strong
        static bool IsStrong(int number)
        {
            int originalNumber = number;
            int sum = 0;

            while (number > 0)
            {
                int digit = number % 10; // Get last digit
                sum += Factorial(digit); // Add factorial of digit
                number /= 10; // Remove last digit
            }


            return sum == originalNumber;
        }
        static void Main(string[] args)
        {
                Console.Write("Enter start of range: ");
                int start = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter end of range: ");
                int end = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"\nStrong Numbers between {start} and {end}:");

                for (int i = start; i <= end; i++)
                {
                    if (IsStrong(i))
                    {
                        Console.WriteLine(i);
                    }
                }
        }
        
    }
}
