namespace Pallindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program in C# to check whether a number is a 
            // palindrome or not. 
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The Entered Number is {(IsPalindrome(number)? "a Palindrome" : "not a Palindrome" ) } ");

        }

        public static bool IsPalindrome(int number)
        {
            int orignalNumber = number;
            int reverse = 0;
            bool IsPalindromeFlag;
            while (number != 0)
            {
                int remainderNumber=number % 10;
                reverse = reverse * 10 + remainderNumber;
                number = number / 10;
            }
            //test if the original number is equal to the reversed number
            return IsPalindromeFlag = (orignalNumber == reverse)? true : false;
        }

    }
}
