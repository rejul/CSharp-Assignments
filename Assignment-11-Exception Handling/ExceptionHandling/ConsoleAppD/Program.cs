namespace ConsoleAppD
{

    // Custom Exception for Prime Number
    public class PrimeNumberException : Exception
    {
        public PrimeNumberException(string message) : base(message) { }
    }
    //Write a method that will return a random number. If the 
    // random number happens to be a prime no, throw an 
    // exception. Call this method in a program that you create and 
    // handle the exception accordingly.  
    // (use Math.random() method to get random number).

    class Program
    {
        // Method to generate random number
        static int GetRandomNumber()
        {
            Random rand = new Random();
            int number = rand.Next(1, 100); // Generate random number between 1 and 99

            if (IsPrime(number))
            {
                throw new PrimeNumberException($"Generated number {number} is PRIME.");
            }

            return number;
        }

        // Method to check if number is prime
        static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static void Main()
        {
            try
            {
                int randomNum = GetRandomNumber();
                Console.WriteLine("Generated Number (not prime): " + randomNum);
            }
            catch (PrimeNumberException ex)
            {
                Console.WriteLine("Exception Caught: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Program execution completed.");
            }
        }
    }

}
