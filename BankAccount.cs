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
        public string ownerName;
        public int accountBallance;

        public BankAccount(int ID, string ownerName, int accountBallance)
        {
            this.ID = ID;
            this.ownerName = ownerName;
            this.accountBallance = accountBallance;
        }

    }
}
