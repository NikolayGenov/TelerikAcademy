using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Person
{
    public class Person
    {
        private uint id; //must be unique
        private string name;

        private static List<uint> identifiers = new List<uint>();
        public uint Id
        {
            get
            {
                return this.id;
            }
            private set
            {
                if (identifiers.IndexOf(value) != -1)
                {
                    throw new ArgumentException("This id is already in the list!");
                }
                identifiers.Add(value);
                this.id = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public Person(uint id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
