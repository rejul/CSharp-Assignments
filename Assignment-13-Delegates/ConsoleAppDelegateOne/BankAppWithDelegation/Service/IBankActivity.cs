using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankAppWithDelegation.Service
{ 
    internal interface IBankActivity
    {
        public void CreateAccount(int accountNumber, double amount);

        public void DisplayAccount(int accountNumber);

        public void Deposit(int accountNumber, double amount);

        public void Withdraw(int accountNumber, double amount);

        public void Transfer(int fromAccount, int toAccount, double amount);





    }
}
