

using System;

namespace ConsoleAppSimpleValidation
{
//<comment>
// Write a C# Sharp program that takes userid and 
// password as input (type string). After 3 wrong attempts, 
// user will be rejected.
// </comment>

    class Program
        {
            static void Main(string[] args)
                {
                    const string validUserName = "rejul";
                    const string validPassword = "123";
                    int attempts = 0;
                    bool isAuthenticated = false;

                    while (attempts < 3 && !isAuthenticated)
                    {   //input 
                        Console.WriteLine("Enter User Name");
                        string userName = Console.ReadLine();

                        Console.WriteLine("Enter Password");
                        string password = Console.ReadLine();
                        //check
                        if (userName == validUserName && password == validPassword)
                        {
                            Console.WriteLine("Login Successful");
                            isAuthenticated = true;
                        }
                        else
                        {
                            attempts++;
                            if (attempts < 3)
                            {
                                Console.WriteLine("Invalid user name or password. Try again.");
                            }
                        }
                    }

                    if (!isAuthenticated)
                    {
                        Console.WriteLine("Login Failed. User rejected after 3 wrong attempts.");
                    }
            }
    }
}