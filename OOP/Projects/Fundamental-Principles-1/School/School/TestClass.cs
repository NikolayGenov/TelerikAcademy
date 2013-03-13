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
            telerikAcademy.AddClass(group1);
            Discipline OOP = new Discipline();
            OOP.Name = "Object Oriented Programming";
            OOP.NumberOfExercises = 5;
            OOP.NumberOfLectures = 10;
            Student student1 = new Student("Pesho", "Peshov", 1001);
            Student student2 = new Student("Ivan", "Ivanov", 1002);
            Student student3 = new Student("Georgi", "Georgiev", 1003);
            Teacher niki = new Teacher("Nikolay", "Kostov");
            Teacher nakov = new Teacher("Svetlin", "Nakov");
            niki.AddDiscipline(OOP);
            nakov.AddDiscipline(OOP);
            group1.AddStudent(student1);
            group1.AddStudent(student2);
            group1.AddStudent(student3);
            group1.AddTeacher(niki);
            group1.AddTeacher(nakov);
            group1.RemoveTeacherFromClass(nakov);
            nakov.RemoveDiscipline(OOP);
            
        }
    }
}