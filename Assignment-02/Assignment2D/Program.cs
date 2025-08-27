namespace Assignment2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Admission

            


            //Write a C# program to find the eligibility of admission for 
            // a professional course based on the following criteria: 
            // Marks in Maths >=65 
            // Marks in Phy >=55 
            // Marks in Chem>=50 
            // Total in all three subject >=180 
            // or 
            // Total in Math and Subjects >=140

            Console.Write("Enter marks in Mathematics: ");
            int maths = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter marks in Physics: ");
            int physics = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter marks in Chemistry: ");
            int chemistry = int.Parse(Console.ReadLine() ?? "0");

            bool eligible =
                (maths >= 65 && physics >= 55 && chemistry >= 50 &&
                 (maths + physics + chemistry >= 180 ||
                  maths + physics >= 140 || maths + chemistry >= 140));

            if (eligible)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
            #endregion Admission
        }
    }
}
