using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    class Class : Comments
    {
        //Each class have some students and list and we implement them with List
        private readonly List<Student> listStudents = new List<Student>();
        private readonly List<Teacher> listTeachers = new List<Teacher>();

        //We have a name for the class
        public string ClassName { get ; set ; }
        
        //Consturctor
        public Class(string name)
        {
            this.ClassName = name;
        }
        
        //And some methods to add students or teahcer and remove them as well
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

        //To print the information about the class
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("Class name: " + this.ClassName);
            foreach (Student student in this.listStudents)
            {
                info.AppendLine(student.ToString());
            }
            foreach (Teacher teacher in this.listTeachers)
            { 
                info.AppendLine(teacher.ToString());
            }
            if (this.Comment != null)
            {
                info.AppendLine("Comment about the class: " + this.Comment);
            }
            return info.ToString();
        }
    }
}