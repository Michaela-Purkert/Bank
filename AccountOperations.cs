using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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
            accountID = 1;
            listOfBankAccounts = new List<BankAccount>();
            CreateBankAccount();
                
        }

        private void CreateBankAccount()
        {
            string bankName = "Bank";
            int bankBallance = 0;
            BankAccount accountOfBank = new BankAccount(accountID, bankName, bankBallance);
            listOfBankAccounts.Add(accountOfBank);
        }

        public int CreateNewAccount()
        {
            accountID = ++accountID;
            Console.WriteLine("Insert name of the owner:");
            string ownerName = Check.NotEmptyString();
            int accountBallance = 0;

            listOfBankAccounts.Add(new BankAccount(accountID, ownerName, accountBallance));
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
                Console.WriteLine("Account ID: " + item.ID + " / owner name: " + item.ownerName + " / account ballance:" + item.accountBallance);
            Console.ReadKey();
        }

        public void AccountDeposit()
        {

        }
    }
}
