using System;
using System.Collections.Generic;
using System.Linq;

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

        public ushort CheckIn(ICollection<Client> clients)
        {
            if (this.WorkPlace == null)
            {
                throw new PersonException("I'm unemployed! Please hire me!");
            }
            return this.WorkPlace.CheckIn(clients);
        }

        public decimal CheckOut(ushort roomNumber)
        {
            if (this.WorkPlace == null)
            {
                throw new PersonException("I'm unemployed! Please hire me!");
            }
            return this.WorkPlace.CheckOut(roomNumber);
        }

        public event EventHandler WakeUpCall; //TODO implement the event
    }
}
