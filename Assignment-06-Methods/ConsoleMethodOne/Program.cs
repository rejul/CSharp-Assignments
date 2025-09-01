namespace ConsoleMethodOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program in C# to create a method to input a 
            // string and count number of spaces are in the string
            

            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            int spaceCount = CountSpaces(input);
            Console.WriteLine($"Number of spaces in the string: {spaceCount}");
        }

        static int CountSpaces(string str)
        {
            int Count = 0;
            if (string.IsNullOrEmpty(str))
            {
                return 0; // Return 0 if the string is null or empty
            }
            foreach (char c in str)
            {
                if (char.IsWhiteSpace(c))
                {
                    Count++;
                }
            }

            return Count;
        }
    }
}
