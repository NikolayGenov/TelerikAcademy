using System;
using System.Collections;
using System.Linq;

namespace LINQStudents
{
    class TestClass
    {
        static void Main(string[] args)
        {
            //Some students
            Student student1 = new Student("Andrei", "Kostov",25);
            Student student2 = new Student("Georgi", "Goshov",30);
            Student student3 = new Student("Svetlin", "Nakov",20);
            Student student4 = new Student("Dimityr", "Petrov",19);
            Student student5 = new Student("Zlatan", "Ivanov",24);
            
            Student[] arrayOfStudents = { student1, student2, student3, student4, student5 };
            
            //Using 'where' and then compare the names we select only those who we need 
            var compareNamesList =
                                  from student in arrayOfStudents
                                  where student.FirstName.CompareTo(student.LastName) < 0
                                  select student;

            //Using a method defined below
            PrintStudents(compareNamesList);
            //Take only those with age in the limits
            var ageStudentList =
                                from student in arrayOfStudents
                                where (student.Age >= 18 && student.Age <= 24)
                                select student;
            PrintStudents(ageStudentList);
            
            //Using LINQ for sorting
            var orderedList =
                             from student in arrayOfStudents
                             orderby student.FirstName descending, student.LastName descending
                             select student;
            PrintStudents(orderedList);
           
            //Using Lambda for sorting
            var orderedListLambda = arrayOfStudents.OrderByDescending(student => student.FirstName).ThenByDescending(student => student.LastName);
            PrintStudents(orderedListLambda);
        }

        //Just to avoid the same foreach loop every time
        static void PrintStudents(IEnumerable listStudents)
        {
            Console.WriteLine("List: ");
            foreach (var student in listStudents)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
        }
    }
}