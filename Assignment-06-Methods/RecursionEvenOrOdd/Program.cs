namespace RecursionEvenOrOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program in C to print even or odd numbers in a 
            // given range using recursion 
            Console.WriteLine("Enter the start of the range:");
            int start= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the end of the range:");
            int end = Convert.ToInt32(Console.ReadLine());
            findOddOrEven();

        }
        static void findOddOrEven(int start, int end)
        {
            if (start > end) return; // Base case: if start exceeds end, stop recursion
            if (start % 2 == 0)
            {
                Console.WriteLine($"{start} is even");
            }
            else
            {
                Console.WriteLine($"{start} is odd");
            }
            findOddOrEven(start + 1, end); // Recursive call with the next number
        }
    }
}
