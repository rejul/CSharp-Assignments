using System;
using System.Globalization;
using System.Collections.Generic;
using ConsoleAppDelegateOne.Model;
//system font library

namespace ConsoleAppDelegateOne.Model
{
    public class Bank
    {
        private Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();

        // Create a new bank account

        public void CreateAccount(int accountNumber, decimal initialBalance = 0)
        {
            if (accounts.ContainsKey(accountNumber))
            {
                Console.WriteLine("Account already exists!");
                return;
            }
            accounts[accountNumber] = new BankAccount(accountNumber, initialBalance);//Assign   new account to dictionary
            Console.WriteLine($"Account {accountNumber} created with balance {initialBalance:C}");
        }

        // Retrieve an account by account number
        public BankAccount GetAccount(int accountNumber)
        {
            if (accounts.ContainsKey(accountNumber))
                return accounts[accountNumber];
            else
                Console.WriteLine("Account not found!");
            return null;
        }

        // Deposit money into an account
        public void Deposit(int accountNumber, decimal amount)
        {
            var account = GetAccount(accountNumber);
            account?.Deposit(amount);
        }

        // Withdraw money from an account
        public void Withdraw(int accountNumber, decimal amount)
        {
            var account = GetAccount(accountNumber);
            account?.Withdraw(amount);
        }

        // Check the balance of an account
        public void CheckBalance(int accountNumber)
        {
            var account = GetAccount(accountNumber);
            account?.ShowBalance();
        }

        // Transfer money between two accounts
        public void Transfer(int fromAccount, int toAccount, decimal amount)
        {
            var sender = GetAccount(fromAccount);
            var receiver = GetAccount(toAccount);

            if (sender == null || receiver == null) return;

            if (amount <= 0)
            {
                Console.WriteLine("Transfer amount must be greater than 0.");
                return;
            }

            if (sender.Balance < amount)
            {
                Console.WriteLine("Insufficient funds. Transfer failed.");
                return;
            }

            sender.Withdraw(amount); 
            receiver.Deposit(amount);

            Console.WriteLine($"Successfully transferred {amount:C} from Account {fromAccount} to Account {toAccount}.");
        }
    }
}
