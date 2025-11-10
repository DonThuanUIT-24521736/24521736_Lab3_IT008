using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai08
{
    public class Account
    {
        public string AccountNumber { get; set; } = "";
        public string CustomerName { get; set; } = "";
        public string Address { get; set; } = "";
        public decimal Money { get; set; }

        public Account() { }

        public Account(string accountNumber, string name, string address, decimal money)
        {
            AccountNumber = accountNumber;
            CustomerName = name;
            Address = address;
            Money = money;
        }
    }
}
