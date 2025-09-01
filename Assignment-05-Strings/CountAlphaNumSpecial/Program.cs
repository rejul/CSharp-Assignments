namespace CountAlphaNumSpecial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program in C# to count a total number of 
            // alphabets, digits and special characters in a string. 
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            int alphabetCount = 0;
            int digitCount = 0;
            int specialCount = 0;

            foreach (char ch in input)
            {
                if (char.IsLetter(ch))
                {
                    alphabetCount++;
                }
                else if (char.IsDigit(ch))
                {
                    digitCount++;
                }
                else
                {
                    specialCount++;
                }
            }

            Console.WriteLine($"Total Alphabets: {alphabetCount}");
            Console.WriteLine($"Total Digits: {digitCount}");
            Console.WriteLine($"Total Special Characters: {specialCount}");
        }
    }
}
