using System;

namespace School
{
    class TestClass
    {
        static void Main()
        {
            //Create a new school and 2 classes in that school
            School telerikAcademy = new School("Telerik Academy");
            Class group1 = new Class("First Group");
            Class group2 = new Class("Second Group");
            telerikAcademy.AddClass(group1);
            telerikAcademy.AddClass(group2);

            //Create 2 disciplines and modify one of them a bit
            Discipline OOP = new Discipline("Object Oriented Programming",10,10);
            OOP.NumberOfLectures = 12;
            Discipline javascript = new Discipline("Javascript part I",10,15);

            //Create some students and teachers
            Student student1 = new Student("Pesho", "Peshov", 1001);
            Student student2 = new Student("Ivan", "Ivanov", 1002);
            Student student3 = new Student("Georgi", "Georgiev", 1003);
            Student student4 = new Student("Petyr", "Petrov", 1101);
            Teacher niki = new Teacher("Nikolay", "Kostov");
            Teacher nakov = new Teacher("Svetlin", "Nakov");

            //Add the disciplnes to the teachers
            niki.AddDiscipline(OOP);
            niki.AddDiscipline(javascript);
            nakov.AddDiscipline(OOP);
            nakov.AddDiscipline(javascript);

            //Add students and teachers to the classes
            group1.AddStudent(student1);
            group1.AddStudent(student2);
            group1.AddStudent(student3);
            group1.AddTeacher(niki);
            group1.AddTeacher(nakov);
            group2.AddStudent(student4);
            
            //Remove a teacher from the class and discipline from a teacher and assign that teacher to another group
            group1.RemoveTeacherFromClass(nakov);
            nakov.RemoveDiscipline(javascript);
            group2.AddTeacher(nakov);
            
            //Add few comments about students and 1 class
            student1.Comment = "Really good student";
            student2.Comment = "Good but can be much better if he tries harder";
            group2.Comment = "This group is too small for now and needs more students";
            
            //Print the whole information about the school
            Console.WriteLine(telerikAcademy);
        }
    }
}