using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareAcademy
{
    //public class Teacher : ITeacher
    //{
    //    public string Name { get; set ; }

    //    public List<ICourse> ListOfCourses;

    //    public Teacher(string name)
    //    {
    //        this.Name = name;
    //        this.ListOfCourses = new List<ICourse>();
    //    }

    //    public void AddCourse(ICourse course)
    //    {
    //        this.ListOfCourses.Add(course);
    //    }

    //    public override string ToString()
    //    {
    //        StringBuilder teacherInfo = new StringBuilder();
    //        teacherInfo.AppendFormat("{0}: Name={1}", this.GetType().Name, this.Name);
    //        if (this.ListOfCourses.Count != 0)
    //        {
    //            teacherInfo.Append("; ");
    //            teacherInfo.Append("Courses=[");
               
    //            foreach (var course in this.ListOfCourses)
    //            {
    //                teacherInfo.Append(course.Name + ", ");
    //            }
    //            string result = teacherInfo.ToString().Trim().TrimEnd(',');
              
    //            result = result.TrimEnd() + "]";
    //            teacherInfo = new StringBuilder(result);
    //        }
    //        return teacherInfo.ToString();
    //    }
    //}
}