namespace ConsoleAppB 
{
    class Program
    {
        static void Main()

        {//Write a program that throws Arithmetic Exception and handle  
         // the exception properly
            try
            {
                Console.Write("Enter numerator: ");
                int num = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter denominator: ");
                int den = Convert.ToInt32(Console.ReadLine());

                // This may throw ArithmeticException if denominator is 0
                int result = num / den;

                Console.WriteLine($"Result = {result}");
            }
            catch (System.ArithmeticException ex)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                Console.WriteLine("Exception Message: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid integers only.");
            }
            finally
            {
                Console.WriteLine("Execution Completed (finally block executed).");
            }
        }
    }
}
