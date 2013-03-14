using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelManager.Person;

namespace HotelManager.Person
{
    public class Receptionist : Personel
    {
        public ICollection<Languages> Languages { get; set; }

        public Receptionist(uint id, string name) 
            : base(id, name)
        {
        }

        public Receptionist(uint id, string name, decimal salary)
            : base(id, name, salary)
        {
        }

        public event EventHandler WakeUpCall; //TODO implement the event
    }
}
