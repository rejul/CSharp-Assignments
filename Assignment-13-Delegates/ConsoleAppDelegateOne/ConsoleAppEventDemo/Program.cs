using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;
using static ConsoleAppEventDemo.Program;

namespace ConsoleAppEventDemo
{
    public delegate string WelcomeDelegate(string userName); //
    internal class Program
    { 
        event WelcomeDelegate welcomeEvent;

        public Program()
        {
            welcomeEvent+= new WelcomeDelegate(this.Welcome);

        }
        static void Main(string[] args)
        {
           //Iniatialize /2 Declaring an Event using the delegate
           //this is publisher
           //(evet lives here and still notify subscribers
             Program? obj = new Program();
             string result = obj.welcomeEvent("Sanjay");
             Console.WriteLine(result);
        }
        //simple subscribers method
        //This is the Subscribers method
        //(it will be executed when event is raised
        public string Welcome(string userName)
            {
                return "Welcome :"+ userName;
            }
        
    }
}
