namespace Assignment3i
{
    internal class Program
    {
        static void Main(string[] args)
        {//Write a program in C# to convert a binary number into a 
         // decimal number without using array, function and while 
         // loop. 

            Console.Write("Enter a binary number: ");
            int binaryNumber = Convert.ToInt32(Console.ReadLine());  // User input (binary number)

            int originalBinary = binaryNumber;  // Store original binary for displaying later
            int decimalNumber = 0;              // Final result in decimal
            int powerOfTwo = 1;                 // Represents 2^position (starts with 2^0)

            // Loop until all digits are processed
            for (int temp = binaryNumber; temp > 0; temp /= 10)
            {
                int lastDigit = temp % 10;                 // Extract the last digit
                decimalNumber += lastDigit * powerOfTwo;   // Add to decimal result
                powerOfTwo *= 2;                           // Move to next power of 2
            }

            Console.WriteLine($"\nBinary Number   : {originalBinary}");
            Console.WriteLine($"Decimal Number  : {decimalNumber}");
        }
    }
}
