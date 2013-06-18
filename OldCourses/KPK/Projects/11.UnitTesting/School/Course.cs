using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolModule
{
    public class Course
    {
        public const int MaxStudentsInClass = 30;

        private string name;
        private string teacherName;
        private readonly IList<Student> students;

        public Course(string name, string teacherName)
        {
            this.Name = name;
            this.TeacherName = teacherName;
            this.students = new List<Student>();
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
                    throw new ArgumentException("Course name can't be null, empty or whitespace!");
                }
                this.name = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Teacher's name can't be null, empty or whitespace!");
                }
                this.teacherName = value;
            }
        }

        public IList<Student> Students
        {
            get
            {
                return this.students;
            }
        }

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student can't be null");
            }
            if (this.students.Count == MaxStudentsInClass)
            {
                throw new InvalidOperationException("The number of students in one class must not exceed " + MaxStudentsInClass);
            }
            if (this.students.Contains(student))
            {
                throw new ArgumentException("This student is already in the class");
            }
            this.students.Add(student);
        }
        
        public void RemoveStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student can't be null");
            }
            if (!this.students.Contains(student))
            {
                throw new ArgumentException("There is no such student in the class.");
            }
            this.students.Remove(student);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine("------COURSE-INFO-------");
            output.AppendFormat("Name = {0}, ", this.Name);

            output.AppendFormat("Teacher = {0} ", this.TeacherName).AppendLine();
            if (this.students.Count > 0)
            {
                output.AppendFormat("Students: \n{0}", this.StudentsAsString());
            }
            output.AppendLine("------END-COURSE-INFO-------");
            return output.ToString();
        }

        private string StudentsAsString()
        {
            StringBuilder studentsAsString = new StringBuilder();
            foreach (Student student in students)
            {
                studentsAsString.AppendLine(student.ToString());
            }
            return studentsAsString.ToString();
        }
    }
}