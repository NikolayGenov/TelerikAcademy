using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelManager.Person;

namespace HotelManager.Person
{
    public class Manager : Personel
    {
        public Manager(uint id, string name) 
            : base(id, name)
        {
        }

        public Manager(uint id, string name, decimal salary)
            : base(id, name, salary)
        {
        }
    }
}
