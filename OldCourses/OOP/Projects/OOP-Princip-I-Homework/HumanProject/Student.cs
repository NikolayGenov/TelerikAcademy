using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanProject
{
    class Student : Human
    {
        public double Grade { get; set; }

        public Student(string firstName, string lastName, double grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.Append(base.ToString());
            info.AppendLine("Grade: " + this.Grade);
            return info.ToString();
        }
    }
}