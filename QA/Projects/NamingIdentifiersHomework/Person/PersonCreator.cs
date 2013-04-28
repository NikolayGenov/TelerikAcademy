using System;

class PersonCreator
{
    enum Gender
    {
        Male,
        Female
    };

    class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Gender Gender { get; set; }
    }
    public void MakePerson(int age)
    {
        Person person = new Person();
        person.Age = age;
        if (age % 2 == 0)
        {
            person.Name = "Svetlin Nakov";
            person.Gender = Gender.Male;
        }
        else
        {
            person.Name = "Ina Dobrilova";
            person.Gender = Gender.Female;
        }
    }
}