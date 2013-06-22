using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanProject
{
    abstract class Human
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("Name :" + this.FirstName + " " + this.LastName);
            return info.ToString();
        }
    }
}