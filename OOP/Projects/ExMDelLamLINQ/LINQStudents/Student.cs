using System;
using System.Text;

namespace LINQStudents
{
    public class Student
    {
        //Class with 3 prop and constructor and one override ToString
        private string firstName;
        private string lastName;
        private int? age;
    
        public Student(string firstName, string lastName, int? age = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }
        
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public int? Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.Append(string.Format("First name= {0} / Last name= {1}", this.FirstName, this.LastName));
            if (this.Age != null)
            {
                info.Append(string.Format("/ Age= {0}", this.Age));
            }
            return info.ToString();
        }
    }
}