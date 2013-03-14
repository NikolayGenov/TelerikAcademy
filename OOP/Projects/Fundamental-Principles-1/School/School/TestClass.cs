using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class TestClass
    {
        static void Main()
        {
            School telerikAcademy = new School("Telerik Academy");
            Class group1 = new Class("First Group");
            Class group2 = new Class("Second Group");
            telerikAcademy.AddClass(group1);
            Discipline OOP = new Discipline("Object Oriented Programming",10,10);
            OOP.NumberOfLectures = 12;
            Discipline javascript = new Discipline("Javascript part 1",10,15);

            Student student1 = new Student("Pesho", "Peshov", 1001);
            Student student2 = new Student("Ivan", "Ivanov", 1002);
            Student student3 = new Student("Georgi", "Georgiev", 1003);
            Student student4 = new Student("Petyr", "Petrov", 1101);
            Teacher niki = new Teacher("Nikolay", "Kostov");
            Teacher nakov = new Teacher("Svetlin", "Nakov");
            niki.AddDiscipline(OOP);
            niki.AddDiscipline(javascript);
            nakov.AddDiscipline(OOP);
            group1.AddStudent(student1);
            group1.AddStudent(student2);
            group1.AddStudent(student3);
            group1.AddTeacher(niki);
            group1.AddTeacher(nakov);
            group1.RemoveTeacherFromClass(nakov);
            nakov.RemoveDiscipline(OOP);
            group2.AddTeacher(niki);
            group2.AddStudent(student4);
            student1.Comment = "Really good student";
            student2.Comment = "Good but can be much better if he tries harder";
            group2.Comment = "This group is too small for now and needs more students";
            //To do  implement to string 
            Console.WriteLine(student2);
        }
    }
}