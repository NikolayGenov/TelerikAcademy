using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Student : Person
    {
        public int ClassID { get; set; }

        public Student(string firstName, string lastName, int classID) : base(firstName, lastName)
        {
            this.ClassID = classID;
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine(string.Format("Student names: {0} {1}, ID:{2}", this.FirstName, this.LastName, this.ClassID));
            if (this.Comment != null)
            {
                info.AppendLine("Comment about the student: " + this.Comment); 
            }
            return info.ToString();
        }
    }
}