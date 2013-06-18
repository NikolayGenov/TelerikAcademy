namespace BankProject
{
    public class LoanAccount : BankAccount
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterestAmount(int months)
        {
            if (this.Customer is IndividualCustomer)
            {
                //Months without interest
                months -= 3;
                return base.CalculateInterestAmount(months);
            }
            else
            {
                //Months without interest for company customers
                months -= 2;
                return base.CalculateInterestAmount(months);
            }
        }
    }
}