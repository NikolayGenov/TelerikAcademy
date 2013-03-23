using System.Text;

namespace ProjectPerson
{
    class Person
    {
        public string Name { get; set; }

        public byte? Age { get; set; }
        
        public Person(string name, byte? age =null)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendFormat("Name: {0}", this.Name).AppendLine();
            if (this.Age != null)
            {
                info.AppendFormat("Age: {0}", this.Age).AppendLine();
            }
            else
            {
                info.AppendLine("The age is not specified");
            }
            return info.ToString();
        }
    }
}