using System;


namespace ProjectStudent
{
    class TestClass
    {
        static void Main(string[] args)
        {
            //Create 3 test students
            Student firstStudent = new Student("Gosho", "Ivanov", "Peshov", "11122", "Gosho Street", "02423423", "gosho@gmail.com", 1,
                Universities.HarvardUniversity, Faculties.FacultyOfComputerScience ,Specialties.ComputerGraphics);
            Student secondStudent = new Student("Ivan", "Georgiev", "Alexandrov", "15624", "Pesho Street", "09415743", "ivan@gmail.com", 2,
                Universities.MassachusettsInstituteofTechnology, Faculties.FacultyOfComputerScience, Specialties.ArtificialIntelligence);
            Student thirdStudent = new Student("Gosho", "Ivanov", "Peshov", "10021", "Ivan Street", "931234", "gosho1@gmail.com", 1,
                Universities.SofiaUniversity, Faculties.FacultyOfComputerScience, Specialties.ComputerProgramming);

            //Clone a student from the first
            Student clonedStundent = firstStudent.Clone() as Student;

            Console.WriteLine(firstStudent.ToString());
            Console.WriteLine(secondStudent.ToString());
            Console.WriteLine(thirdStudent.ToString());
            Console.WriteLine("First student == Second Student ?:{0}", firstStudent == secondStudent);
            Console.WriteLine("First student != Third Student ?:{0}", firstStudent != thirdStudent);
            Console.WriteLine("First student Equals Cloned Student ?:{0}", firstStudent.Equals(clonedStundent));
            Console.WriteLine("First student compared to Second Student (in ints): {0}", firstStudent.CompareTo(secondStudent));
            Console.WriteLine("First student compared to Third Student (in ints): {0}", firstStudent.CompareTo(thirdStudent));
            Console.WriteLine("First student compared to Cloned Student (in ints): {0}", firstStudent.CompareTo(clonedStundent));

            //Before change
            Console.WriteLine("Is first student number equal to cloned first student number ? {0}", firstStudent.MobilePhone == clonedStundent.MobilePhone);
            //The first student changes his number
            firstStudent.MobilePhone = "088888888";
            
            //Compare the cloned first student to the changed one
            Console.WriteLine("Is first student number equal to cloned first student number ? {0}", firstStudent.MobilePhone == clonedStundent.MobilePhone);
        }
    }
}