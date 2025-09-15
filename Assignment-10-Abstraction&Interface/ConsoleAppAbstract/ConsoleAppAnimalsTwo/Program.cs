using ConsoleAppAnimalsTwo.Model;

namespace ConsoleAppAnimalsTwo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Next derive a class from Animals called Cat. Implement the 
            // Saysomething() method in the derived class. The 
            // Saysomething() method should print the following message on 
            // the user’s.“Cats Say Meoow” Derive another class called Dog 
            // from the Animals abstract base class. This time the 
            // SaySomething()  method should print the following message 
            // on the user’s. “Dogs Say Bow Wow”

            Cat kitty =new Cat();
            kitty.SaySomething();
            Dog dolly=new Dog();
            dolly.SaySomething();

        }
    }
}
