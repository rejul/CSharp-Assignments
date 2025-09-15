using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assigment3C
{
    internal class Program
    { 
        #region Main 
        static void Main(string[] args)
        {
           
            //Write a C# program to check whether a given number is 
            // an Armstrong number or not
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            // Call the method to check if the number is an Armstrong number
            CheckArmstrong(number);
            
        }
        #endregion
        #region CheckArmstrong
        static void CheckArmstrong(int number)
        {   
            int originalNumber=number; //Save the original number for comparison

            int digits= number.ToString().Length;
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                sum += (int)Math.Pow(digit, digits);
                number /= 10;
            }
           
            if (sum == originalNumber)
            {
                Console.WriteLine($"{originalNumber} is an Armstrong number.");
            }
            else
            {
                Console.WriteLine($"{originalNumber} is not an Armstrong number.");
            }
        }
        #endregion

    }
}
