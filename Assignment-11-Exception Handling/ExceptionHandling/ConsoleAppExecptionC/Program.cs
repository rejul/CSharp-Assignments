namespace ConsoleAppC
{
    class Program
    {
        //Create an array having 10 elements. Try to print the element in  
        // the 11th position. Catch the appropriate exception.
        static void Main()
        {
            try
            {
                // Creating an array of 10 elements
                int[] numbers = new int[10];

                // Initializing array with sample values
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = i + 1;
                }

                Console.WriteLine("Trying to access the 11th element...");

                // This will throw IndexOutOfRangeException
                Console.WriteLine("Element at 11th position: " + numbers[10]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: Attempted to access an element outside the array bounds.");
                Console.WriteLine("Exception Message: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Program execution completed.");
            }
        }
    }
}
