using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment3a
{
    internal class Program
    {
        //<summary>
        //Write a program in C# to display the n terms of square 
        //natural number and their sum.
        //</summary>

        static void Main(string[] args)
        {
            Console.Write("Enter the number of terms (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            Console.WriteLine($"The first {n} square natural numbers are:");

            for (int i = 1; i <= n; i++)
            {
                int square = i * i;
                Console.Write($"{square} ");
                sum += square;
            }

            Console.WriteLine($"\nThe sum of squares is: {sum}");
        }
    }
    
}
