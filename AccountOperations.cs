using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckInput;

namespace Bank
{
    internal class AccountOperations
    {
        public List<BankAccount> listOfBankAccounts;
        int accountID;
        public AccountOperations()
        {
            accountID = 0;
            listOfBankAccounts = new List<BankAccount>();
        }

        public int CreateNewAccount()
        {
            int randomAccountID = 0;
            Random accountNumber = new Random();
            randomAccountID = accountNumber.Next(000000000, 999999999);

            Console.WriteLine("Insert your name:");
            string ownerName = Check.NotEmptyString();
            int accountBallance = 0;
            accountID = accountID + 1;

            BankAccount bankAccount = new BankAccount(accountID, randomAccountID, ownerName, accountBallance);
            listOfBankAccounts.Add(bankAccount);
            Console.ReadKey();
            return accountID;
        }

        public void CheckAccounts()
        {
            foreach (var item in listOfBankAccounts)
                Console.WriteLine("Account ID: " + item.ID + " / owner name: " + item.ownerName + " / account number: " + item.accountNumber + " / account ballance:" + item.accountBallance);
            Console.ReadKey();
        }
    }
}
