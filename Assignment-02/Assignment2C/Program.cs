namespace Assignment2C
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Write a C# program to read roll no, name and marks of 
            // three subjects and calculate the total, percentage and 
            // division 

            // Read roll no
            Console.Write("Enter the Roll no: ");
            int rollNo = int.Parse(Console.ReadLine());

            // Read name
            Console.Write("Enter the name: ");
            string name = Console.ReadLine();

            // Read marks for three subjects
            int[] marks = new int[3];
            int total = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter marks for subject {i + 1}: ");
                marks[i] = int.Parse(Console.ReadLine());
                total += marks[i];
            }

            // Calculate percentage
            float percentage = total / 3.0f;

            // Determine division
            string division;
            if (percentage >= 60)
                division = "First";
            else if (percentage >= 45)
                division = "Second";
            else if (percentage >= 33)
                division = "Third";
            else
                division = "Fail";

            // Output results
            Console.WriteLine("\n--- Student Result ---");
            Console.WriteLine($"Roll No: {rollNo}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Total Marks: {total}");
            Console.WriteLine($"Percentage: {percentage:F2}");
            Console.WriteLine($"Division: {division}");
        }
    }
    }
}
