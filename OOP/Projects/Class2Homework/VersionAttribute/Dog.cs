using System;

namespace VersionAttribute
{
    [VersionAttribute(3.14)]

    //Sample class
    public class Dog
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Dog() : this("Sharo")
        {
        }

        public Dog(string name)
        {
            this.Name = name;
        }
        
        public override string ToString()
        {
            string text = string.Format("My name is {0}, Bau!", this.Name);
            return text;
        }
    }
}