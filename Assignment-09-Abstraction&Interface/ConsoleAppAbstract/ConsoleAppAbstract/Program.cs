using ConsoleAppAbstract.Model;
namespace ConsoleAppAbstract

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a valid temp of a mammal");
            string bodyPart = Console.ReadLine();
            IMammals mammal = new Mammal();
            try
            {
                int  bodyTemp = mammal.GetBodyTemp(bodyPart);
                Console.WriteLine($"The body temp is {bodyTemp}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
       
            


        }
    }
}
