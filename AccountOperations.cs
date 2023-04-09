using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckInput;
using ConsoleTools;

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

        private void DeleteAccount(int idAccount)
        {
            bool checkID = false;
            foreach (var item in listOfBankAccounts)
            {
                if (item.ID == idAccount)
                {
                    listOfBankAccounts.Remove(item);
                    checkID = true;
                    Console.WriteLine("Account with ID {0} has been removed", idAccount);
                    Console.ReadKey();
                    break;

                }
            }

            if (checkID == false)
            {
                Console.WriteLine("You must choose an existing account number");
                Console.ReadKey();
            }

        }

        public void DeleteCertainAccount()
        {
            int deleteAccount = 0;
            Console.WriteLine("Choose the ID of the account you want to delete:");
            deleteAccount = Check.PositiveIntCheck();

            DeleteAccount(deleteAccount);

        }


        public void CheckAccounts()
        {
            foreach (var item in listOfBankAccounts)
                Console.WriteLine("Account ID: " + item.ID + " / owner name: " + item.ownerName + " / account number: " + item.accountNumber + " / account ballance:" + item.accountBallance);
            Console.ReadKey();
        }
    }
}
