namespace Assignment3h
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program in C# to find the number and sum of all 
            // integer between 100 and 200 which are divisible by 9. 

            int sum = 0;
            Console.WriteLine("Numbers between 100 and 200 divisible by 9 are:");

            for (int i = 100; i <= 200; i++)
            {
                if (i % 9 == 0)
                {
                    Console.Write(i + " ");
                    sum += i;
                }
            }

            Console.WriteLine("\n\nThe sum of these numbers is: " + sum);
        }
    }
}
