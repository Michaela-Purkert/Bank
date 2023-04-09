using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class BankAccount
    {
        public int ID;
        public int accountNumber;
        public string ownerName;
        public int accountBallance;

        public BankAccount(int ID, int accountNumber, string ownerName, int accountBallance)
        {
            this.ID = ID;
            this.accountNumber = accountNumber;
            this.ownerName = ownerName;
            this.accountBallance = accountBallance;
        }

    }
}
