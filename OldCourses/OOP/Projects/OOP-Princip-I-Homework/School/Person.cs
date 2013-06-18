namespace School
{
    class Person : Comments
    {
        //A base class for the student and the teacher
        //Each person have First and last name
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}