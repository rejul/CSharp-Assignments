using System;
using ConsoleAppDelegateOne.Model;
using ConsoleAppDelegateOne.Util;

namespace ConsoleAppDelegateOne
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;//getting UTF-8 Encoding

            //starting banking system
            Bank bank = new Bank();
            TransactionDelegate depositDelegate = bank.Deposit;
            TransactionDelegate withdrawDelegate = bank.Withdraw;

            Console.WriteLine("____ Banking System ____");
            try
            {
                while (true)
                {
                    Console.WriteLine("\nMenu:");
                    Console.WriteLine("1. Create Account");
                    Console.WriteLine("2. Deposit");
                    Console.WriteLine("3. Withdraw");
                    Console.WriteLine("4. Check Balance");
                    Console.WriteLine("5. Transfer");
                    Console.WriteLine("6. Exit");
                    Console.Write("Enter choice: ");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Console.Write("Enter Account Number: ");
                            int accNum = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Initial Balance: ");
                            decimal initBal = Convert.ToDecimal(Console.ReadLine());
                            bank.CreateAccount(accNum, initBal);
                            break;

                        case "2":
                            Console.Write("Enter Account Number: ");
                            accNum = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Amount to Deposit: ");
                            decimal depositAmt = Convert.ToDecimal(Console.ReadLine());
                            depositDelegate(accNum, depositAmt);
                            break;

                        case "3":
                            Console.Write("Enter Account Number: ");
                            accNum = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Amount to Withdraw: ");
                            decimal withdrawAmt = Convert.ToDecimal(Console.ReadLine());
                            withdrawDelegate(accNum, withdrawAmt);
                            break;

                        case "4":
                            Console.Write("Enter Account Number: ");
                            accNum = Convert.ToInt32(Console.ReadLine());
                            bank.CheckBalance(accNum);
                            break;

                        case "5":
                            Console.Write("Enter Sender Account Number: ");
                            int fromAcc = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Receiver Account Number: ");
                            int toAcc = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Amount to Transfer: ");
                            decimal transferAmt = Convert.ToDecimal(Console.ReadLine());
                            bank.Transfer(fromAcc, toAcc, transferAmt);
                            break;

                        case "6":
                            Console.WriteLine("Exiting... Thank you!");
                            return;

                        default:
                            Console.WriteLine("Invalid choice, please try again.");
                            break;
                    }
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Please enter numeric values where required.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
