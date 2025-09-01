namespace SwapTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Write a program in C# to create a method to swap the 
           // values of two integer numbers. 
           Console.WriteLine("Enter the first integer:");
           int firstNumber = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Enter the Second Number: ");
           int secondNumber = Convert.ToInt32(Console.ReadLine());
            //using without using a third variable
            firstNumber,secondNumber= SwapValues(firstNumber, secondNumber);
            // Replace this line:
            // firstNumber,secondNumber= SwapValues(firstNumber, secondNumber);

            // With the following code:
            (firstNumber, secondNumber) = SwapValues(firstNumber, secondNumber);
            Console.WriteLine($"After swapping: First Number = {firstNumber}, Second Number = {secondNumber}");


        }

        static (int, int) SwapValues(int a, int b)
        {
            // Swapping values without using a third variable
            a = a + b; // Step 1: Add both numbers
            b = a - b; // Step 2: Subtract the new value of 'a' by 'b' to get the original 'a'
            a = a - b; // Step 3: Subtract the new value of 'b' from 'a' to get the original 'b'
            return (a, b); // Return the swapped values
        }
    }
}
