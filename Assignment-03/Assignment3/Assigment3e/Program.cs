using System;

namespace FibonacciSeries
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Prompt user
            Console.Write("Enter the number of terms: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"First {n} terms of Fibonacci series:");

            // Generate and display series
            DisplayFibonacci(n);
        }

        public static void DisplayFibonacci(int n)
        {
            int first = 0, second = 1;

            for (int i = 1; i <= n; i++)
            {
                Console.Write(first + (i < n ? ", " : "")); // Print number

                int next = first + second; // Calculate next term
                first = second;
                second = next;
            }
        }
    }
}