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
    }
}