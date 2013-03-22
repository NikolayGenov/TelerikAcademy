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
    class Student
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
    }