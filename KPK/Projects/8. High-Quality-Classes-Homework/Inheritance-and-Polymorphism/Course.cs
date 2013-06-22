using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public abstract class Course
    {
        private string name;
        private string teacherName;
        private IList<string> students;

        public Course(string name, string teacherName, IList<string> students)
        {
            this.Name = name;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name can't be blank or null");
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
            set
            {
                this.teacherName = value;
            }
        }

        public IList<string> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                if (value != null)
                {
                    this.students = new List<string>();
                    foreach (var student in value)
                    {
                        this.students.Add(student);
                    }
                }
                else
                {
                    this.students = null;
                }
            }
        }

        public void AddStudent(string student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Can't add null student");
            }
            if (this.students == null)
            {
                this.students = new List<string>();
            }

            this.students.Add(student);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Name = {0}; ", this.Name);
            result.Append(this.Name);
            if (this.TeacherName != null)
            {
                result.AppendFormat("Teacher = {0}; ", this.TeacherName);
            }
            result.AppendFormat("Students = {0}; ", this.GetStudentsAsString());
            return result.ToString();
        }
        
        private string GetStudentsAsString()
        {
            if (this.students == null || this.students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.students) + " }";
            }
        }
    }
}