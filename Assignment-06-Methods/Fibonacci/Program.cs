namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program in C# to create a method to display the 
            // n number Fibonacci sequence 

            Console.WriteLine("Enter the number of terms in the Fibonacci sequence:");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Please enter a valid positive integer.");
            }
            Console.WriteLine($"Fibonacci sequence up to {n} terms:");
            DisplayFibonacciSequence(n);

        }
        static void DisplayFibonacciSequence(int n)
        {
            if (n < 1)
            {
                Console.WriteLine("Please enter a positive integer greater than 0.");
                return;
            }
            int a = 0, b = 1;
            Console.Write($"{a} {b} ");
            for (int i = 2; i < n; i++)
            {
                int next = a + b;
                Console.Write($"{next} ");
                a = b;
                b = next;
            }
            Console.WriteLine(); // New line after the sequence
        }
    }
}
