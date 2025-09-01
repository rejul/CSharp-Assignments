namespace StringCharInReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Write a program in C# to print individual characters of 
           // the string in reverse order 
           Console.WriteLine("Enter the String");
           string s = Console.ReadLine();
           string reversedString=String.Empty;

           for(int i =0; i < s.Length; i++)
           {
               reversedString += s[s.Length - 1 - i];
           }

           Console.WriteLine($"Characters in reverse order are:{reversedString } ");



        }
    }
}
