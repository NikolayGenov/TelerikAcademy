namespace BankProject
{
    public abstract class BankAccount : IDeposit
    {
        public Customer Customer { get; set; }

        public decimal Balance { get; set; }

        public decimal InterestRate { get; set; }

        public BankAccount(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public virtual void DrawMoney(decimal amount)
        {
            this.Balance -= amount;
        }
        
        public void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }

        public virtual decimal CalculateInterestAmount(int months)
        {
            if (months <= 0)
            {
                return 0.0m;
            }
            else
            {
                return this.Balance * months * this.InterestRate;
            }
        }
    }
}