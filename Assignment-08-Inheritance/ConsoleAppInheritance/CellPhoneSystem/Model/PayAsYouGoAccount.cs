using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellPhoneSystem.Model
{
    public class PayAsYouGoAccount : CellphoneAccount
    {
        public char AccountType { get; set; } // C, P, A

        public PayAsYouGoAccount(string phoneNumber, double callTime, double cost, char type)
            : base(phoneNumber, callTime, cost)
        {
            AccountType = type;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"PayAsYouGo Account -> Phone: {PhoneNumber}, CallTime: {TotalCallTime} mins, Cost: ${TotalCost}, Type: {AccountType}");
        }
    }
}
