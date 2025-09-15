using System;

namespace ConsoleAppDelegateOne.Model
{
    public class BankAccount
    {
        public int AccountNumber { get; private set; }
        public decimal Balance { get; private set; }

        public BankAccount(int accountNumber, decimal initialBalance = 0)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be greater than 0.");
                return;
            }
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New Balance: {Balance:C}");
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be greater than 0.");
                return;
            }
            if (Balance - amount < 0)
            {
                Console.WriteLine("Insufficient funds. Transaction failed.");
                return;
            }
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount:C}. New Balance: {Balance:C}");
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Account {AccountNumber} Balance: {Balance:C}");
        }
    }
}