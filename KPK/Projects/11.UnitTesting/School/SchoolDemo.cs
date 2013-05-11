using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class SchoolDemo
    {
        static void Main()
        {
            int numberOfStudents = 25;
            Student[] students = new Student[numberOfStudents];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student("Gosho");
            }
            Course KPK = new Course("High Quality Code", "Nakov");
            foreach (Student student in students)
            {
                student.JoinCourse(KPK);
            }
            Console.WriteLine(KPK);

            //TODO ADD MORE STUFF
        }
    }
}