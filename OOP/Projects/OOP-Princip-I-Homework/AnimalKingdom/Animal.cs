using System;
using System.Text;

namespace AnimalKingdom
{
    //Should be abstract 
    abstract class Animal : ISound
    {
        //Create the 3 props
        public string Name { get; set; }

        public Sex Sex { get; set; }

        public byte Age { get; set; }

        //And base constructor we use a lot
        public Animal(string name, Sex sex, byte age)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
        }

        //Make it abstract so we can define it later
        public abstract string MakeSound();
        
        //Print the info about each animal 
        //We've included gettype so that implementation to each is not needed and can get it even from here
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("Species: " + this.GetType());
            info.AppendLine("Name: " + this.Name);
            info.AppendLine("Sex: " + this.Sex);
            info.AppendLine("Age: " + this.Age);
           
            return info.ToString();
        }
    }
}