using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppWithDelegation.Model
{
    public class BankModel
    {
        public int AccountNumber { get; set; }
        public double Balance { get; set; }

        public BankModel() { }
        public BankModel(int accountNumber, double initialBalance =0)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }
    }
}
      
