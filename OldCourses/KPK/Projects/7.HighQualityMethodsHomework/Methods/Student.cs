using System;
using System.Globalization;

namespace Methods
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string OtherInfo { get; set; }
        
        private DateTime dateOfBirth;

        public string DateOfBirth
        {
            get
            {
                return dateOfBirth.ToString();
            }
            set
            {
                if (DateTime.TryParseExact(value, "dd/MM/yyyy", new CultureInfo("bg-BG"), DateTimeStyles.None, out dateOfBirth))
                {
                    throw new AggregateException("Invalid given date!");
                }
            }
        }

        public Student(string firstName, string lastName, string dateOfBirth, string otherInfo = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.OtherInfo = otherInfo;
        }

        public bool IsOlderThan(Student other)
        {
            DateTime dateFirstStudent = this.dateOfBirth;
            DateTime dateOtherStudent = other.dateOfBirth;            
            bool isOlder = dateFirstStudent > dateOtherStudent;
            return isOlder;
        }
    }
}