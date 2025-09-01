namespace SumOfElementsInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program in C# to calculate the sum of elements 
            // in an array using methods. 
            Console.WriteLine("Enter the number of elements in the array:");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Please enter a valid positive integer.");
            }

            int[] numbers = new int[n];
            Console.WriteLine($"Enter {n} integers (separated by spaces):");
            string[] input = Console.ReadLine().Split(' ');

            int s = SumOfElementsInArray(input);

        }

        static int SumOfElementsInArray(string[] input)
        {
            int sum = 0;
            foreach (string str in input)
            {
                if (int.TryParse(str, out int number))
                {
                    sum += number;
                }
                else
                {
                    Console.WriteLine($"'{str}' is not a valid integer. It will be ignored.");
                }
            }
            Console.WriteLine($"The sum of the elements in the array is: {sum}");
            return sum;
        }
    }
}
