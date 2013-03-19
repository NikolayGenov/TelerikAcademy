using System;


namespace BankProject
{
    class TestClass
    {
        static void Main(string[] args)
        {
            //Add new bank
            Bank telerikBank = new Bank("Telerik Bank");

            //Two new customers
            Customer pesho = new IndividualCustomer("Pesho");
            Customer peshoCompany = new CompanyCustomer("Pesho's Greatest Company");

            //Three bank accounts
            BankAccount peshosBankAcc = new DepositAccount(pesho, 100.00m, 0.02m);
            BankAccount peshosCompanyBankAcc = new LoanAccount(peshoCompany, 100000.0m, 0.02m);
            BankAccount peshosMortgageAcc = new MortgageAccount(pesho, 1000m, 0.01m);

            //Create the accounts at the bank
            telerikBank.CreateAccount(peshosBankAcc);
            telerikBank.CreateAccount(peshosCompanyBankAcc);
            telerikBank.CreateAccount(peshosMortgageAcc);
            //And remove one
            telerikBank.CloseAccount(peshosMortgageAcc);
       
            //Deposit some money
            peshosBankAcc.DepositMoney(10000);
            peshosCompanyBankAcc.DepositMoney(1000);
            
            //Draw some money from the aacount
            peshosBankAcc.DrawMoney(595.9m);

            //Calculate the interest acount for 5 months
            int months = 5;
            Console.WriteLine("Interest amount for {0} months {1} for customer {2} with ID {3}", months,
                peshosBankAcc.CalculateInterestAmount(months), peshosBankAcc.Customer.Name, peshosBankAcc.Customer.ID);
            Console.WriteLine("Interest amount for {0} months {1} for customer {2} with ID {3}", months,
                peshosCompanyBankAcc.CalculateInterestAmount(months), peshosCompanyBankAcc.Customer.Name, peshosCompanyBankAcc.Customer.ID);
        }
    }
}