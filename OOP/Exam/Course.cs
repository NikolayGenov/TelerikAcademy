using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareAcademy
{
    //public abstract class Course : ICourse
    //{
    //    protected IList<string> topics;

    //    public string Name { get ; set ; }

    //    public ITeacher Teacher { get ; set ; }

    //    public Course(string name, ITeacher teacher=null)
    //    {
    //        this.Name = name;
    //        this.Teacher = teacher;
    //        this.topics = new List<string>();
    //    }

    //    public void AddTopic(string topic)
    //    {
    //        this.topics.Add(topic);
    //    }

    //    public override string ToString()
    //    {
    //        StringBuilder courseInfo = new StringBuilder();
    //        courseInfo.AppendFormat("{0}: Name={1}; ", this.GetType().Name, this.Name);
    //        if (this.Teacher != null)
    //        {
    //            courseInfo.AppendFormat("Teacher={0};", this.Teacher.Name);
    //        }
    //        else
    //        {
    //            return courseInfo.ToString().Trim().TrimEnd(';') ;
    //        }
    //        if (this.topics.Count != 0)
    //        {
    //            courseInfo.Append(" Topics=[");
    //            foreach (var topic in this.topics)
    //            {
    //                courseInfo.Append(topic + ", ");
    //            }
    //            string result = courseInfo.ToString().Trim().TrimEnd(',');
    //            result = result.TrimEnd() + "]";
    //            courseInfo = new StringBuilder(result);
                
    //        }

    //        return courseInfo.ToString().TrimEnd(';');
    //    }
    //}
}