namespace BankProject
{
    public abstract class Customer
    {
        public string Name { get; set; }

        private static int id = 1000;
        
        public int ID { get; private set; }
        
        public Customer(string name)
        {
            this.Name = name;
            this.ID = id++;
        }
    }
}