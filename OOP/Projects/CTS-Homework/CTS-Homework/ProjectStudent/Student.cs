using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Define a class Student, which contains data about a student – 
* first, middle and last name, SSN, permanent address, mobile phone 
* e-mail, course, specialty, university, faculty. Use an enumeration 
* for the specialties, universities and faculties. Override the standard methods, 
* inherited by  System.Object: Equals(), ToString(), GetHashCode() and 
* operators == and !=.
*/
namespace ProjectStudent
{
    class Student : IComparable<Student>
    {
        public string FirstName { get; private set; }

        public string MiddleName { get; private set; }

        public string LastName { get; private set; }

        public string SSN { get; private set; }

        public string PermanentAddress { get; private set; }

        public string MobilePhone { get; private set; }

        public string Email { get; private set; }

        public byte Course { get; set; }

        public Universities University { get; private set; }

        public Specialties Specialty { get; private set; }

        public Faculties Faculty { get; private set; }
        
        //Countructor
        public Student(string firstName, string middleName, string lastName, string ssn, string permanentAddress, string mobilePhone,
            string email, byte course, Universities university, Specialties specialty, Faculties faculty)
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
            this.Specialty = specialty;
            this.Faculty = faculty;
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
            {//TO DO
                //TO DO
                 //var students =new Student[] { this, otherStudent };
                 //    students.OrderBy(
            }
            throw new NotImplementedException();
        }

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
            infoStudent.AppendFormat("Name : {0} {1} {2}", this.FirstName, this.MiddleName, this.LastName).AppendLine();
            infoStudent.AppendFormat("Social Security Number: {0}", this.SSN).AppendLine();
            infoStudent.AppendFormat("Mobile phone number {0} , E-mail: {1}", this.MobilePhone, this.Email).AppendLine();
            infoStudent.AppendFormat("University: {0} , Faculty: {1} ,\n Specialty: {2} , Course: {3}", this.University,
                this.Faculty, this.Specialty, this.Course).AppendLine();
            return infoStudent.ToString();
        }
    }
}