using System;
using System.Collections.Generic;

namespace SchoolModule
{
    public class School
    {
        private string name;

        private readonly IList<Course> courses;

        public School(string name)
        {
            this.Name = name;
            this.courses = new List<Course>();
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
                    throw new ArgumentException("School name can't be null, empty or whitespace!");
                }
                this.name = value;
            }
        }
        
        public IList<Course> Courses
        {
            get
            {
                return this.courses;
            }
        }

        public void AddCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course can't be null");
            }
            if (this.courses.Contains(course))
            {
                throw new ArgumentException("This course is already listed in the school");
            }
            this.courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course can't be null");
            }
            if (!this.courses.Contains(course))
            {
                throw new ArgumentException("There is no such course in the school");
            }
            this.courses.Remove(course);
        }
    }
}