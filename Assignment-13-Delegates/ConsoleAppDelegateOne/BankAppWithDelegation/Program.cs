using System.Diagnostics;
using BankAppWithDelegation.Util;
using BankAppWithDelegation.Model;
using BankAppWithDelegation.Service;
namespace BankAppWithDelegation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Main method is the entry point of the application
            Console.WriteLine("Welcome to the Bank Application ");
            BankActivity bankActivity = new BankActivity();
            bankActivity.TransactionOccurred += message => Console.WriteLine($"Log: {message}");

            while (true)
            {
                Console.WriteLine("_______ABC BANK MENU______");
                Console.WriteLine("1.Create Account");
                Console.WriteLine("2.Deposit");
                Console.WriteLine("3.Withdraw");
                Console.WriteLine("4.Check Balance");
                Console.WriteLine("5.Transfer");
                Console.WriteLine("6.Exit");
                Console.Write("Select an option (1-6): ");
                string? choice = Console.ReadLine();

                //Add switch case 
                switch (choice)
                {
                    case "1":
                        var cValidation = new Validation(bankActivity);
                        cValidation.CreateAccountInput();
                        break;
                    case "2":
                        var dValidation = new Validation(bankActivity);
                        dValidation.DepositInput();

                        break;
                    case "3":
                        var wValidation = new Validation(bankActivity);
                        wValidation.WithdrawInput();
                        break;
                    case "4":
                         var displayValidation = new Validation(bankActivity);
                         displayValidation.Display();
                        break;
                    case "5":
                        var tValidation = new Validation(bankActivity);
                        tValidation.TransferInput();
                        break;
                    case "6":
                        Console.WriteLine("Thank you for using the Bank Application. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please select a number between 1 and 6.");
                        break;
                }
       


            }



        }
    }
}
