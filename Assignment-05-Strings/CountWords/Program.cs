using System.Diagnostics.CodeAnalysis;

namespace CountWords
{
    internal class Program
    {
        static void Main(string[] args)
        {//Write a program in C# to count the total number of 
         // words in a string 
            Console.WriteLine("Enter the String");
            string input = Console.ReadLine();

            int count=1;

            if (!string.IsNullOrEmpty(input) && !string.IsNullOrWhiteSpace(input))
            {
                foreach (char ch in input)
                {
                    if (char.IsWhiteSpace(ch))
                    {
                        count++;
                    }

                }
            }

            else
            {
                Console.WriteLine("Not a correct Input");
            }

            //print
            Console.WriteLine($"No words are {count}");
        }
    }
}
