using System.Collections.Generic;

namespace BankProject
{
    public class Bank
    {
        public string BankName { get; set; }

        protected List<BankAccount> listOfAccounts;

        public Bank(string bankName)
        {
            this.BankName = bankName;
            this.listOfAccounts = new List<BankAccount>();
        }

        public void CreateAccount(BankAccount account)
        {
            this.listOfAccounts.Add(account);
        }

        public void CloseAccount(BankAccount account)
        {
            this.listOfAccounts.Remove(account);
        }
    }
}