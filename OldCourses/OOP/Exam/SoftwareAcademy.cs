using System;
using System.Linq;
using System.Text;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;
using System.Collections.Generic;

namespace SoftwareAcademy
{
    public interface ITeacher
    {
        string Name { get; set; }

        void AddCourse(ICourse course);

        string ToString();
    }

    public interface ICourse
    {
        string Name { get; set; }

        ITeacher Teacher { get; set; }

        void AddTopic(string topic);

        string ToString();
    }

    public interface ILocalCourse : ICourse
    {
        string Lab { get; set; }
    }

    public interface IOffsiteCourse : ICourse
    {
        string Town { get; set; }
    }

    public interface ICourseFactory
    {
        ITeacher CreateTeacher(string name);

        ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab);

        IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town);
    }

    public class CourseFactory : ICourseFactory
    {
        public ITeacher CreateTeacher(string name)
        {
            return new Teacher(name);
        }

        public ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab)
        {
            return new LocalCourse(name, teacher, lab);
        }

        public IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town)
        {
            return new OffsiteCourse(name, teacher, town);
        }
    }

    public class SoftwareAcademyCommandExecutor
    {
        static void Main()
        {
            string csharpCode = ReadInputCSharpCode();
            CompileAndRun(csharpCode);
        }

        private static string ReadInputCSharpCode()
        {
            StringBuilder result = new StringBuilder();
            string line;
            while ((line = Console.ReadLine()) != "")
            {
                result.AppendLine(line);
            }
            return result.ToString();
        }

        static void CompileAndRun(string csharpCode)
        {
            // Prepare a C# program for compilation
            string[] csharpClass =
            {
                @"using System;
                  using SoftwareAcademy;

                  public class RuntimeCompiledClass
                  {
                     public static void Main()
                     {"
                +
                csharpCode + @"
                     }
                  }"
            };

            // Compile the C# program
            CompilerParameters compilerParams = new CompilerParameters();
            compilerParams.GenerateInMemory = true;
            compilerParams.TempFiles = new TempFileCollection(".");
            compilerParams.ReferencedAssemblies.Add("System.dll");
            compilerParams.ReferencedAssemblies.Add(Assembly.GetExecutingAssembly().Location);
            CSharpCodeProvider csharpProvider = new CSharpCodeProvider();
            CompilerResults compile = csharpProvider.CompileAssemblyFromSource(
                compilerParams, csharpClass);

            // Check for compilation errors
            if (compile.Errors.HasErrors)
            {
                string errorMsg = "Compilation error: ";
                foreach (CompilerError ce in compile.Errors)
                {
                    errorMsg += "\r\n" + ce.ToString();
                }
                throw new Exception(errorMsg);
            }

            // Invoke the Main() method of the compiled class
            Assembly assembly = compile.CompiledAssembly;
            Module module = assembly.GetModules()[0];
            Type type = module.GetType("RuntimeCompiledClass");
            MethodInfo methInfo = type.GetMethod("Main");
            methInfo.Invoke(null, null);
        }
    }

    public class Teacher : ITeacher
    {
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException();
                this.name = value;
            }
        }

        public List<ICourse> ListOfCourses;

        public Teacher(string name)
        {
            this.Name = name;
            this.ListOfCourses = new List<ICourse>();
        }

        public void AddCourse(ICourse course)
        {
            this.ListOfCourses.Add(course);
        }

        public override string ToString()
        {
            StringBuilder teacherInfo = new StringBuilder();
            teacherInfo.AppendFormat("{0}: Name={1}", this.GetType().Name, this.Name);
            if (this.ListOfCourses.Count != 0)
            {
                teacherInfo.Append("; ");
                teacherInfo.Append("Courses=[");

                foreach (var course in this.ListOfCourses)
                {
                    teacherInfo.Append(course.Name + ", ");
                }
                string result = teacherInfo.ToString().Trim().TrimEnd(',');

                result = result.TrimEnd() + "]";
                teacherInfo = new StringBuilder(result);
            }
            return teacherInfo.ToString();
        }
    }

    public abstract class Course : ICourse
    {
        protected IList<string> topics;
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException();
                this.name = value;
            }
        }
        
        public ITeacher Teacher { get; set; }

        public Course(string name, ITeacher teacher = null)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.topics = new List<string>();
        }

        public void AddTopic(string topic)
        {
            this.topics.Add(topic);
        }

        public override string ToString()
        {
            StringBuilder courseInfo = new StringBuilder();
            courseInfo.AppendFormat("{0}: Name={1}; ", this.GetType().Name, this.Name);
            if (this.Teacher != null)
            {
                courseInfo.AppendFormat("Teacher={0};", this.Teacher.Name);
            }
            else
            {
                return courseInfo.ToString().Trim().TrimEnd(';');
            }
            if (this.topics.Count != 0)
            {
                courseInfo.Append(" Topics=[");
                foreach (var topic in this.topics)
                {
                    courseInfo.Append(topic + ", ");
                }
                string result = courseInfo.ToString().Trim().TrimEnd(',');
                result = result.TrimEnd() + "]";
                courseInfo = new StringBuilder(result);
            }

            return courseInfo.ToString().TrimEnd(';');
        }
    }

    public class LocalCourse : Course, ILocalCourse
    {
        private string lab;

        public string Lab
        {
            get
            {
                return this.lab;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException();
                this.lab = value;
            }
        }

        public LocalCourse(string name, ITeacher teacher, string lab) : base(name, teacher)
        {
            this.Lab = lab;
        }

        public override string ToString()
        {
            StringBuilder localInfo = new StringBuilder(base.ToString());
            if (this.Lab != null)
            {
                localInfo.AppendFormat("; Lab={0}", this.Lab);
            }
            return localInfo.ToString();
        }
    }

    public class OffsiteCourse : Course, IOffsiteCourse
    {
        private string town ;

        public string Town
        {
            get
            {
                return this.town;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException();
                this.town = value;
            }
        }

        public OffsiteCourse(string name, ITeacher teacher, string town) : base(name, teacher)
        {
            this.Town = town;
        }

        public override string ToString()
        {
            StringBuilder offsiteInfo = new StringBuilder(base.ToString());
            if (this.Town != null)
            {
                offsiteInfo.AppendFormat("; Town={0}", this.Town);
            }
            return offsiteInfo.ToString();
        }
    }
}