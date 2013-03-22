using System;
using System.Linq;
using System.Text;

namespace ProjectStudent
{
    class Student : IComparable<Student>, ICloneable
    {
        //Properties
        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
        public string SSN { get; private set; }//This number is unique
        public string PermanentAddress { get; private set; }
        public string MobilePhone { get; set; }
        public string Email { get; private set; }
        public byte Course { get; set; }
        public Universities University { get; private set; }
        public Specialties Specialty { get; private set; }
        public Faculties Faculty { get; private set; }
        
        //Countructor
        public Student(string firstName, string middleName, string lastName, string ssn, string permanentAddress, string mobilePhone,
            string email, byte course, Universities university, Faculties faculty, Specialties specialty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.University = university;
            this.Faculty = faculty;
            this.Specialty = specialty;
        }

        //Cloning by creating a new Student and get the same info 
        public object Clone()
        {
            Student cloneStundent =
                new Student(
                    this.FirstName,
                    this.MiddleName,
                    this.LastName,
                    this.SSN,
                    this.PermanentAddress,
                    this.MobilePhone,
                    this.Email,
                    this.Course,
                    this.University,
                    this.Faculty,
                    this.Specialty); 
                   
            return cloneStundent;
        }
        
        public int CompareTo(Student otherStudent)
        {
            //Comparing them by SSN
            if (this.Equals(otherStudent))
            {
                //If they have the same SSN which is unique - it's the same student
                return 0;
            }
            else
            { 
                var students = new Student[] { this, otherStudent }.OrderBy(x => x.FirstName).ThenBy(x => x.MiddleName).ThenBy(x => x.LastName).ThenBy(x => x.SSN);
                var student = students.First();
                bool result = this.Equals(student);
                return result ? -1 : 1;
            }
        }

        //Overiding operators
        public static bool operator ==(Student studentOne, Student studentTwo)
        {
            return studentOne.Equals(studentTwo);
        }

        public static bool operator !=(Student studentOne, Student studentTwo)
        {
            return !studentOne.Equals(studentTwo);
        }

        //and equals 
        public override bool Equals(object compareStudentAsObj)
        {
            //Becase the SSN must be unique for each person
            Student compareStudent = compareStudentAsObj as Student;
            bool result = (this.SSN == compareStudent.SSN) ? true : false;
            return result;
        }

        public override int GetHashCode()
        {
            return SSN.GetHashCode();
        }

        public override string ToString()
        {
            //Add all the info about the student and return is as a string
            StringBuilder infoStudent = new StringBuilder();
            infoStudent.AppendLine("Student info: "); 
            infoStudent.AppendFormat("Name : {0} {1} {2}", this.FirstName, this.MiddleName, this.LastName).AppendLine();
            infoStudent.AppendFormat("Social Security Number: {0}", this.SSN).AppendLine();
            infoStudent.AppendFormat("Mobile phone number {0} , E-mail: {1}", this.MobilePhone, this.Email).AppendLine();
            infoStudent.AppendFormat("University: {0} , Faculty: {1} ,\n Specialty: {2} , Course: {3}", this.University,
                this.Faculty, this.Specialty, this.Course).AppendLine();
            return infoStudent.ToString();
        }
    }
}