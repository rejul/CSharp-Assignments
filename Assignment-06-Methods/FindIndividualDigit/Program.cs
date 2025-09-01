using System.Runtime.InteropServices;

namespace FindIndividualDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program in C# to display the individual digits of a 
            //    given number using recursion.
           // 
           Console.WriteLine("Enter the Number");
           int number= Convert.ToInt32(Console.ReadLine());

           DisplayIndividualDigits();


        }
        static void DisplayIndividualDigits(int number)
        {
            if (number < 10)
            {
                Console.WriteLine(number); // Base case: print the last digit
            }
            else
            {
                DisplayIndividualDigits(number / 10); // Recursive call with the number without the last digit
                Console.WriteLine(number % 10); // Print the last digit after the recursive call
            }
        }
    }
}
