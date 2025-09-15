using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAppWithDelegation.Model;
using BankAppWithDelegation.Service;

namespace BankAppWithDelegation.Util
{
    //Validation class inherits BankModel to use its properties
    public delegate void BankModelDelegate(int accountNumber, double amount);
    public delegate void BankTransferDelegate(int sourceAccount, int destinationAccount, double amount);
    public delegate void DisplayDelegate(int accountNumber);

    public class Validation
    {//here Both input and validation logic are handled
       
        // Constructor accepts a shared BankActivity instance
        private BankActivity? _bankModel;
        public Validation(){}
        public Validation(BankActivity bankModel)
        {
            _bankModel = bankModel;
        }

        public void CreateAccountInput()
        {
            Console.Write("Enter Account Number: ");
            string? accountInput = Console.ReadLine();
            if (!int.TryParse(accountInput, out int account) || account < 0)
            {
                Console.WriteLine("Invalid Account Number");
            }
            Console.Write("Enter Initial Deposit Amount: ");
            string? amountInput = Console.ReadLine();
            if (!double.TryParse(amountInput, out double amount) || amount < 0)
            {
                Console.WriteLine("Initial deposit must be greater than or equal to zero");
        
            }
            BankModelDelegate createAccount = _bankModel.CreateAccount;
            createAccount(account, amount);
        }

        public void DepositInput()
        {
            Console.Write("Enter Account Number: ");
            string? accountInput = Console.ReadLine();
            if (!int.TryParse(accountInput, out int account) || account < 0)
            {
                Console.WriteLine("Invalid Account Number");
  
            }

            Console.Write("Enter Deposit Amount: ");
            string? amountInput = Console.ReadLine();
            if (!double.TryParse(amountInput, out double amount) || amount <= 0)
            {
                Console.WriteLine("Deposit amount must be greater than zero");
 
            }

            BankModelDelegate depositAmount = _bankModel.Deposit;
            depositAmount(account, amount);
            
        }

        public void WithdrawInput()
        {
            Console.Write("Enter Account Number: ");
            string? accountInput = Console.ReadLine();
            if (!int.TryParse(accountInput, out int account) || account < 0)
            {
                Console.WriteLine("Invalid Account Number");
             
            }

            Console.Write("Enter Withdrawal Amount: ");
            string? amountInput = Console.ReadLine();
            if (!double.TryParse(amountInput, out double amount) || amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be greater than zero");
  
            }

            BankModelDelegate withdrawAmount = _bankModel.Withdraw;
            withdrawAmount(account, amount);
  
        }

        public void Display()
        {
            Console.WriteLine("Enter the Account");
            string? accountInput = Console.ReadLine();
            if (!int.TryParse(accountInput, out int account) || account < 0)
            {
                Console.WriteLine("Invalid Account Number");

            }
            DisplayDelegate displayAccount = _bankModel.DisplayAccount;
            displayAccount(account);

        }

        public void TransferInput()
        {
            Console.Write("Enter Source Account Number: ");
            string? sourceInput = Console.ReadLine();
            if (!int.TryParse(sourceInput, out int sourceAccount) || sourceAccount < 0)
            {
                Console.WriteLine("Invalid Source Account Number");
     
            }

            Console.Write("Enter Destination Account Number: ");
            string? destinationInput = Console.ReadLine();
            if (!int.TryParse(destinationInput, out int destinationAccount) || destinationAccount < 0)
            {
                Console.WriteLine("Invalid Destination Account Number");
        
            }

            Console.Write("Enter Transfer Amount: ");
            string? amountInput = Console.ReadLine();
            if (!double.TryParse(amountInput, out double amount) || amount <= 0)
            {
                Console.WriteLine("Transfer amount must be greater than zero");
        
            }

            BankTransferDelegate transfer =_bankModel.Transfer;
            transfer(sourceAccount, destinationAccount, amount);

        }
    }
}
