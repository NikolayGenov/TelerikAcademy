using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    class School : Comments
    {
        public string Name { get; set; }
        
        //We have some classes in each school where we can add or remove some of them
        private readonly List<Class> schoolClasses = new List<Class>();

        public School(string schoolName)
        {
            this.Name = schoolName;
        }

        public void AddClass(Class schoolClass)
        {
            this.schoolClasses.Add(schoolClass);
        }

        public void RemoveClass(Class schoolClass)
        {
            this.schoolClasses.Remove(schoolClass);
        }

        //And print all the information about the school
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("School name " + this.Name);
            foreach (Class schoolClass in this.schoolClasses)
            {
                info.AppendLine(schoolClass.ToString());
            }
            if (this.Comment != null)
            {
                info.AppendLine("Comment about the school: " + this.Comment);
            }
            return info.ToString();
        }
    }
}