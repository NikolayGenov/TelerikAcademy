using System;
using System.Text;

namespace School
{
    class Student : Person
    {
        //Student have first and last name from the class person but have classID number as well
        public int ClassID { get; set; }

        public Student(string firstName, string lastName, int classID) : base(firstName, lastName)
        {
            this.ClassID = classID;
        }

        //Print the info about the student
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine(string.Format("Student names: {0} {1}, ID: {2}", this.FirstName, this.LastName, this.ClassID));
            if (this.Comment != null)
            {
                info.AppendLine("Comment about the student: " + this.Comment); 
            }
            return info.ToString();
        }
    }
}