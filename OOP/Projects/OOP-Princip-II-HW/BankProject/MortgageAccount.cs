namespace BankProject
{
    public class MortgageAccount : BankAccount
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        //Overriding as always
        public override decimal CalculateInterestAmount(int months)
        {
            if (this.Customer is CompanyCustomer)
            {
                if (months > 12)
                { //Not to get 0 in here - that's why we use tht If statement
                    return base.CalculateInterestAmount(months - 12) / 2;
                }
                else
                {
                    return base.CalculateInterestAmount(months) / 2;
                }
            }
            else
            { // For individual customers
                if (months <= 6)
                {
                    return 0.0m;
                }
                else
                {
                    return base.CalculateInterestAmount(months);
                }
            }
        }
    }
}