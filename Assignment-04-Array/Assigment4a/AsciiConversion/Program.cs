using System.Diagnostics.CodeAnalysis;

namespace AsciiConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string input = Console.ReadLine();
            int sum = 0;
            foreach (char ch in input)

            { if(char.IsDigit(ch))
                sum+= ch - '0'; //when subtracting 2 characters, the result is the difference in their ASCII values
            }

            Console.WriteLine(sum);
        }
    }
}
