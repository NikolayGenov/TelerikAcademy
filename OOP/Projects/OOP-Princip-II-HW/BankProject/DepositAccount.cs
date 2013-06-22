namespace BankProject
{
    public class DepositAccount : BankAccount, IDrawable
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterestAmount(int months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0.0m;
            }
            return base.CalculateInterestAmount(months);
        }
    }
}