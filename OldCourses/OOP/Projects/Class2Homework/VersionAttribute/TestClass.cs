using System;

namespace VersionAttribute
{
    class TestClass
    {
        static void Main(string[] args)
        {
            //Printing the version of the class Dog and then some sample of the class
            Type type = typeof(Dog);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute attr in allAttributes)
            {
                Console.WriteLine("Current version: {0}", attr.Version);
            }
            Dog sharo = new Dog("Sharo");
            Console.WriteLine(sharo.ToString());
        }
    }
}