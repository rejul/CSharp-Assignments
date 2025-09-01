namespace SumofIndividualNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program in C# to create a method to calculate 
            // the sum of the individual digits of a given number 
            Console.WriteLine("Enter a number to calculate the sum of its digits:");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = SumOfDigits(number);
            Console.WriteLine($"The sum of the digits of {number} is: {sum}");

        }

        static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10; // Add the last digit to the sum
                number /= 10; // Remove the last digit
            }
            return sum; // Return the total sum of digits
        }
    }
}
