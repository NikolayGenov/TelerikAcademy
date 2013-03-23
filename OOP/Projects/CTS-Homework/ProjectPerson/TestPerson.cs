using System;

namespace ProjectPerson
{
    class TestPerson
    {
        static void Main(string[] args)
        {
            //Some random tests
            Person personOne = new Person("Gosho Peshov", 30);
            Person personTwo = new Person("Pesho Goshov");
            Console.WriteLine(personOne);
            Console.WriteLine(personTwo);
        }
    }
}