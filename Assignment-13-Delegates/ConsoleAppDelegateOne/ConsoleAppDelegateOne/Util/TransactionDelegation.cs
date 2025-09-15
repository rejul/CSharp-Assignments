using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDelegateOne.Util
{
    // Delegate for transaction operations
    public delegate void TransactionDelegate(int accountNumber, decimal amount);
}
