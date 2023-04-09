using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class BankAccount
    {
        private uint accountNumber;
        private string ownerName;
        private int accountBalance;

        public BankAccount(uint accountNumber, string ownerName, int accountBalance)
        {
            this.accountNumber = accountNumber;
            this.ownerName = ownerName;
            this.accountBalance = accountBalance;
        }

    }
}
