using System.Threading.Channels;

namespace CheckPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program in C# to create a method to check 
            //whether a number is prime or not
            Console.WriteLine("Enter a number to check if it is prime:");
            int number= Convert.ToInt32(Console.ReadLine());
            bool _isPrime = IsPrime(number);
        }

        static bool IsPrime(int number)
        {
            if (number <= 1) return false; // 0 and 1 are not prime numbers
            if (number == 2) return true; // 2 is the only even prime number
            if (number % 2 == 0) return false; // Exclude all other even numbers
            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                {
                    Console.WriteLine($"{number} is not a prime number.");
                    return false;
                }
            }
            Console.WriteLine($"{number} is a prime number.");
            return true;
        }
    }
}
