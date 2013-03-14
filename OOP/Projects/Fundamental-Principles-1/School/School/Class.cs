using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    class Class : Comments
    {
        private readonly List<Student> listStudents = new List<Student>();
        private readonly List<Teacher> listTeachers = new List<Teacher>();

        public string ClassName { get ; set ; }
        
        public Class(string name)
        {
            this.ClassName = name;
        }

        public void AddStudent(Student student)
        {
            this.listStudents.Add(student);
        }

        public void ExpelStudent(Student student)
        {
            this.listStudents.Remove(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            this.listTeachers.Add(teacher);
        }

        public void RemoveTeacherFromClass(Teacher teacher)
        {
            this.listTeachers.Remove(teacher);
        }
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            foreach (Student student in listStudents)
            {
                info.AppendLine(student.ToString());
            }
            foreach (Teacher teacher in listTeachers)
            {// TO DO
                throw new NotImplementedException;
                info.AppendLine(student.ToString());
            }
            if (this.Comment != null)
            {
                info.AppendLine("Comment about the student: " + this.Comment);
            }
            return info.ToString();
        }
    }
}