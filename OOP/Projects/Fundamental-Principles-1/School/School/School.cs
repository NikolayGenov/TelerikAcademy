using System;
using System.Collections.Generic;

namespace School
{
    class School : Comments
    {
        public string Name { get; set; }

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
    }
}