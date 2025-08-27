namespace Assignment2A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //<summary>
            //Write a C# program to read the age of a candidate and 
            //determine whether it is eligible for casting his/her own
            //vote 
            Console.WriteLine("Enter the Age");
            int age = int.Parse(Console.ReadLine());
            if (age > 18)
            {
                Console.WriteLine("You are eligible for voting");
            }
            else
            {
                Console.WriteLine("You are not eligible");
            }
        }
    }
}
