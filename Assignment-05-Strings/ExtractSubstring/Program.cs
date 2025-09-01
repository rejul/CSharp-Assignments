using System.Text;

namespace ExtractSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main()
            {
                Console.Write("Enter the main string: ");
                string input = Console.ReadLine();

                Console.Write("Enter the starting index: ");
                int start = int.Parse(Console.ReadLine());

                Console.Write("Enter the length of substring: ");
                int length = int.Parse(Console.ReadLine());

                // Using StringBuilder
                string result = ExtractSubstringSb(input, start, length);

                Console.WriteLine($"(StringBuilder version) Substring: {result}");
            }

            static string ExtractSubstringSb(string str, int start, int length)
            {
                StringBuilder sb = new StringBuilder();

                for (int i = start; i < start + length; i++)
                {
                    sb.Append(str[i]);
                }

                return sb.ToString();
            }
        }
    }
}
