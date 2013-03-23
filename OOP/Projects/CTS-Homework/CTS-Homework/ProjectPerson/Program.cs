using System;

namespace ProjectPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personOne = new Person("Gosho Peshov", 30);
            Person personTwo = new Person("Pesho Goshov");
            Console.WriteLine(personOne);
            Console.WriteLine(personTwo);
        }
    }
}