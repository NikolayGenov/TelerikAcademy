using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanProject
{
    class TestClass
    {
        static void Main(string[] args)
        {
            //Create a list from students and add 10 students to it
            List<Student> listOfStudents = new List<Student>();
            listOfStudents.Add(new Student("Dimityr", "Ivanov", 3.75));
            listOfStudents.Add(new Student("Asen", "Georgiev", 2));
            listOfStudents.Add(new Student("Nikolay", "Kostov", 3.8));
            listOfStudents.Add(new Student("Rancho", "Ranchov", 4.6));
            listOfStudents.Add(new Student("Georgi", "Georgiev", 6));
            listOfStudents.Add(new Student("Ivailo", "Ivanov", 4.9));
            listOfStudents.Add(new Student("Svetlin", "Nakov", 5.5));
            listOfStudents.Add(new Student("Nikolay", "Ivanov", 4.5));
            listOfStudents.Add(new Student("Svetlin", "Georgiev", 3.5));
            listOfStudents.Add(new Student("Georgi", "Ivanov", 4.85));

            //Sort the students by grade in the desired order
            var sortedStudents = from student in listOfStudents
                                 orderby student.Grade ascending
                                 select student;
            Console.WriteLine("Students sorted by grades: \n");
            //Print the students
            foreach (var item in sortedStudents)
            {
                Console.WriteLine(item);
            }

            //Do the same thing with workers
            List<Worker> listOfWorkers = new List<Worker>();
            listOfWorkers.Add(new Worker("Ivan", "Ivanov", 244.50m, 39.5m));
            listOfWorkers.Add(new Worker("Alex", "Alexandrov", 263m, 35m));
            listOfWorkers.Add(new Worker("Angel", "Angelov", 643m, 22.5m));
            listOfWorkers.Add(new Worker("Dimityr", "Petrov", 553.50m, 42m));
            listOfWorkers.Add(new Worker("Petyr", "Dimitrov", 355.50m, 50m));
            listOfWorkers.Add(new Worker("Georgi", "Georgiev", 150.50m, 20m));
            listOfWorkers.Add(new Worker("Zlatan", "Zlatanov", 400m, 36m));
            listOfWorkers.Add(new Worker("Nikolay", "Kostov", 283.50m, 33.5m));
            listOfWorkers.Add(new Worker("Ivan", "Petrov", 353.50m, 39m));
            listOfWorkers.Add(new Worker("Zlatan", "Ivanov", 353.50m, 40m));

            //Ordering them with the method call in the desired order
            Console.WriteLine("Workers sorted by money made per hour:\n");
           
            var sortedWorkers = from worker in listOfWorkers
                                orderby worker.MoneyPerHour() descending
                                select worker;
            //Then print them
            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine(worker);
            }

            //Create a new list with the base type and then merge the two list into it
            List<Human> allPeople = new List<Human>();
            allPeople.AddRange(listOfStudents);
            allPeople.AddRange(listOfWorkers);
            
            //Sorting the people first by first name and then by their last name
            var sortedPeople = from person in allPeople
                               orderby person.FirstName, person.LastName ascending
                               select person;

            //Print the result
            Console.WriteLine("Sorted by names\n");         
            foreach (var person in sortedPeople)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName);
            }
            //To do - add all new names and values and format it
        }
    }
}