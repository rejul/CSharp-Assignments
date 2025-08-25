using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellPhoneSystem.Model
{
    public class ContractAccount : CellphoneAccount
    {
        public string HolderName { get; set; }
        public string Address { get; set; }
        public int ContractMonths { get; set; }

        public ContractAccount(string phoneNumber, double callTime, double cost, string holder, string address, int months)
            : base(phoneNumber, callTime, cost)
        {
            HolderName = holder;
            Address = address;
            ContractMonths = months;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Contract Account -> Phone: {PhoneNumber}, Name: {HolderName}, Address: {Address}, Contract: {ContractMonths} months, CallTime: {TotalCallTime} mins, Cost: ${TotalCost}");
        }
    }
}
