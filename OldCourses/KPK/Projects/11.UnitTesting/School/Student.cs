using System;
using System.Linq;

namespace SchoolModule
{
    public class Student
    {
        public const int MinIdNumber = 100000;
        public const int MaxIdNumber = 999999;
        private static int studentCurrentId = MinIdNumber;

        private string name;
        private int id;

        public Student(string name)
        {
            this.Name = name;
            this.Id = GetId();
        }
      
        public int Id
        {
            get
            {
                return this.id;
            }
            private set
            {
                if (MinIdNumber > value || value > MaxIdNumber)
                {
                    throw new ArgumentOutOfRangeException("Invalid Id for the student");
                }
                this.id = value;
            }
        }
        
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                { 
                    throw new ArgumentException("Student's name can't be null, empty or whitespace!");
                }
                this.name = value;
            }
        }

        private int GetId()
        {
            if (studentCurrentId > MaxIdNumber + 1)
            {
                studentCurrentId = MinIdNumber;
            }
            return studentCurrentId++;
        }
        
        public void JoinCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course can't be null");
            }
            course.AddStudent(this);
        }

        public void LeaveCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course can't be null");
            }
            course.RemoveStudent(this);
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Id: {1}", this.Name, this.Id);
        }
    }
}