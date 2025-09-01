using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellPhoneSystem.Model
{
    public abstract class CellphoneAccount
    {
        public string PhoneNumber { get; set; }
        public double TotalCallTime { get; set; }
        public double TotalCost { get; set; }

        protected CellphoneAccount(string phoneNumber, double callTime, double cost)
        {
            PhoneNumber = phoneNumber;
            TotalCallTime = callTime;
            TotalCost = cost;
        }

        public abstract void DisplayInfo();
    }
}
