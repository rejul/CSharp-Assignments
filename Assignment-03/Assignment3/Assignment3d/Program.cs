using System.Reflection.Metadata;

namespace Assignment3d
{
    public class Program
    {
        static void Main(string[] args)
        {
            //summary
            //Write a C# program to determine whether a given 
            //number is prime or not

            Console.WriteLine("Enter a number to check if it is prime:");
            int number = Convert.ToInt32(Console.ReadLine());
            string value = $"The give number is {(CheckPrime(number)?"Prime":"Non Prime")}";
            Console.WriteLine(value);



        }

        //Check Function
        public static bool  CheckPrime(int number)
        {
            int limit= (int)Math.Sqrt(number);

            if (number <= 1) return false; // 0, 1, negatives are not prime
            if (number <= 3) return true;  // 2 and 3 are prime


            int i = 2;
            

            while (i < limit)
            {
                if (number%i == 0)
                {   
                    return  false;
                }

                i++;
            }

            return true;
        }
    }
}
