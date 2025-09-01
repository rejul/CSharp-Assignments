using System.Threading.Channels;

namespace LengthOfString
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //Write a program in C# to find the length of a string 
         // without using library function.
         Console.WriteLine("Enter the String");
         string s = Console.ReadLine();
         int count = 0;
         foreach (char ch in s)
         {
             count++;   
            }
         
         Console.WriteLine("Length of the string is: " + count);

        }

    }
}
