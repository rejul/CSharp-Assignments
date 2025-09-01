namespace CompareString
{
    internal class Program
    {
        static void Main()
        {
            // Write a program in C# to compare two strings for equality
            Console.Write("Enter first string: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter second string: ");
            string str2 = Console.ReadLine();
            char.IsAsciiDigit()
            if (AreStringsEqual(str1, str2))
                Console.WriteLine("Both strings are equal.");
            else
                Console.WriteLine("Strings are NOT equal.");
        }

        static bool AreStringsEqual(string s1, string s2)
        {
            // Step 1: Check length
            if (s1.Length != s2.Length)
                return false;

            // Step 2: Compare characters one by one
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                    return false;
            }

            return true; // All characters matched
        }
    }
}
