using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalKingdom
{
    class TestClass
    {
        static void Main(string[] args)
        {
            //Three arrays of animals
            Dog[] dogArray =
            {
                new Dog("Sharo", Sex.Male, 12),
                new Dog("Dona", Sex.Female, 5)
            };
            Frog[] frogArray =
            {
                new Frog("Frogy The Frog", Sex.Male, 1),
                new Frog("Prince Charming", Sex.Male, 3)
            };
            Cat[] catArray =
            {
                new Tomcat("Tom", 10),
                new Kitten("Cute Kitty", 1)
            };
            //Create a list and add all of them to it
            List<Animal> listOfAnimals = new List<Animal>();
            listOfAnimals.AddRange(dogArray);
            listOfAnimals.AddRange(frogArray);
            listOfAnimals.AddRange(catArray);
            
            //Print the info about them and make them make their sound
            foreach (var animal in listOfAnimals)
            {
                Console.Write(animal);
                Console.WriteLine(animal.MakeSound());
                Console.WriteLine();
            }

            //Take the average of the age of each kind
            Console.WriteLine("Average dog age: {0}", dogArray.Average((x) => x.Age));
            Console.WriteLine("Average frog age: {0}", frogArray.Average((x) => x.Age));
            Console.WriteLine("Average cat age: {0}", catArray.Average((x) => x.Age));
        }
    }
}