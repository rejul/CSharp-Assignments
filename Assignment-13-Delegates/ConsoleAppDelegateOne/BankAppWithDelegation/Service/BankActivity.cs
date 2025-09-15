using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using BankAppWithDelegation.Model;
using BankAppWithDelegation.Service;
using Microsoft.VisualBasic;

namespace BankAppWithDelegation.Service
{
    //public delegate void TransactionMethod(int account, double amount);
    public delegate void TransactionEventHandler(string message);

    //BankActivity has many accounts so it inherits BankModel to use its properties
    public class BankActivity:BankModel, IBankActivity
    {
        public event  TransactionEventHandler TransactionOccurred;

        private Dictionary<int,BankModel> _accounts = new Dictionary<int,BankModel>();

        //Create Account
        public void CreateAccount(int accountNumber , double amount )
        {
            if (_accounts.ContainsKey(accountNumber))
            {
                TransactionOccurred.Invoke("Account not found");
                return;
            }
            else
            { //Create new account
                BankModel account = new BankModel(accountNumber, amount);
                _accounts.Add(accountNumber, account);
                
                Console.WriteLine("Account Created Successfully");
                TransactionOccurred?.Invoke($"{amount} has been Deposited to {accountNumber} ");
                return;
            }

        }


        //Display account details
        public void DisplayAccount(int accountNumber)
        {
            if (_accounts.ContainsKey(accountNumber))
            {
                var account = GetAccount(accountNumber);
                Console.WriteLine($"Account Number: {account.AccountNumber}, Balance: {account.Balance}");
            }
            else
            {
                TransactionOccurred.Invoke("Account not found");
                return;
            }
        }

        //Deposit
        public void Deposit(int accountNumber , double amount)
        {
            if (_accounts.ContainsKey(accountNumber))
            {
                var account = GetAccount(accountNumber);
                account.Balance += amount;
                TransactionOccurred.Invoke($"{amount} has been Deposited to {accountNumber} ");
            }
            else
            {
                TransactionOccurred.Invoke("Account not found");
                return;
            }

        }

        //Withdraw
        public void Withdraw(int accountNumber, double amount)
        {
            if (_accounts.ContainsKey(accountNumber))
            {   
                var account = GetAccount(accountNumber);
                if (account.Balance < amount)
                {
                    TransactionOccurred.Invoke("Insufficient Balance");
                    return;
                }
                account.Balance -= amount;
                TransactionOccurred.Invoke($"{amount} has been Withdrawn from {accountNumber} ");
            }
            else
            {
                TransactionOccurred.Invoke("Account not found");
                return;
            }

        }

        //Transfer
        public void Transfer(int fromAccountNumber, int toAccountNumber, double amount)
        {
            if (_accounts.ContainsKey(fromAccountNumber) && _accounts.ContainsKey(toAccountNumber))
            {
              
                Withdraw(fromAccountNumber, amount);
                Deposit(toAccountNumber, amount);
                TransactionOccurred.Invoke($"{amount} has been Transferred from {fromAccountNumber} to {toAccountNumber} ");
            }
            else
            {
                TransactionOccurred.Invoke("One or Both account not found");
                return;
            }

        }

        //Get Account used by other methods to get account details
        public BankModel GetAccount(int accountNumber)
        {
            if (_accounts.ContainsKey(accountNumber))
                return _accounts[accountNumber];
            else
            {
                TransactionOccurred.Invoke("Account not found");
                return null;
            }
        }
    }
}
