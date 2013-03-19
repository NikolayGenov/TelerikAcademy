namespace BankProject
{
    public class CompanyCustomer : Customer
    {
        public CompanyCustomer(string companyName) : base(companyName)
        {
            this.Name = companyName;
        }
    }
}