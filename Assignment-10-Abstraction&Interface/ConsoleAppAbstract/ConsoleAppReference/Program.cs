using ConsoleAppReference.Interface;

namespace ConsoleAppReference
{
    public class Program
    {
        static void Main(string[] args)
        {
            Numbers obj = new Numbers(100);

            // Reference through IFirst
            IFirst fRef = obj;
            fRef.Display();                   // Calls IFirst.Display
            Console.WriteLine(fRef.GetValue());  // Available

            // Reference through ISecond
            ISecond sRef = obj;
            sRef.Display();                   // Calls ISecond.Display
            sRef.Demo();                      // Available

            // Direct object reference
            Console.WriteLine(obj.GetValue()); //  Accessible
            obj.Demo();                        //  Accessible

        
        }
    }
}
