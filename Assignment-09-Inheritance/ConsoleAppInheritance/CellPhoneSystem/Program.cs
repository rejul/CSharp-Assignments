using CellPhoneSystem.Model;

namespace CellPhoneSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {//Develop a cellphone accounts system, which will be used to manage the 
         // accounts of a cellphone company. The company has two types of 
         // accounts, Contract and PayAsYouGo. For every account the cellphone 
         // number, total call time used and total cost of calls needs to be stored. For 
         // PayAsYouGo accounts, you also need to store the type, Callmore time, 
         // Peak time or Any time (C, P, A). For Contract accounts you need to store 
         // the account holders name, address, and the length of the contract in 
         // months. The cellphone accounts system needs handle many accounts, 
         // PayAsYouGo and Contract. It also needs to provide information to a user 
         // interface, which allows a user to add new accounts, to display all the 
         // accounts and to search for the details of a particular account using the 
         // cellphone number.

            List<CellphoneAccount> accounts = new List<CellphoneAccount>();

            while (true)
            {
                Console.WriteLine("1. Add PayAsYouGo Account");
                Console.WriteLine("2. Add Contract Account");
                Console.WriteLine("3. Display All Accounts");
                Console.WriteLine("4. Search by Phone Number");
                Console.WriteLine("5. Exit");
                Console.Write("Choose option: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Phone Number: ");
                        string phone1 = Console.ReadLine();
                        Console.Write("Enter Total Call Time: ");
                        double callTime1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Total Cost: ");
                        double cost1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Type (C=Callmore, P=Peak, A=Any): ");
                        char type = Convert.ToChar(Console.ReadLine().ToUpper());

                        accounts.Add(new PayAsYouGoAccount(phone1, callTime1, cost1, type));
                        Console.WriteLine("✅ PayAsYouGo account added successfully!");
                        break;

                    case 2:
                        Console.Write("Enter Phone Number: ");
                        string phone2 = Console.ReadLine();
                        Console.Write("Enter Total Call Time: ");
                        double callTime2 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Total Cost: ");
                        double cost2 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Holder Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Address: ");
                        string address = Console.ReadLine();
                        Console.Write("Enter Contract Months: ");
                        int months = Convert.ToInt32(Console.ReadLine());

                        accounts.Add(new ContractAccount(phone2, callTime2, cost2, name, address, months));
                        Console.WriteLine("✅ Contract account added successfully!");
                        break;

                    case 3:
                        Console.WriteLine("\n--- All Accounts ---");
                        if (accounts.Count == 0)
                            Console.WriteLine("No accounts available.");
                        else
                            foreach (var acc in accounts)
                                acc.DisplayInfo();
                        break;

                    case 4:
                        Console.Write("Enter phone number to search: ");
                        string searchPhone = Console.ReadLine();
                        var found = accounts.Find(a => a.PhoneNumber == searchPhone);

                        if (found != null)
                            found.DisplayInfo();
                        else
                            Console.WriteLine("❌ Account not found.");
                        break;

                    case 5:
                        Console.WriteLine("Exiting program...");
                        return;

                    default:
                        Console.WriteLine("⚠ Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
