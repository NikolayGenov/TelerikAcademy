using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Person
{
    public class Receptionist : Personel
    {
        public Receptionist(uint id, string name, decimal salary) : this(id, name, salary, new List<Languages> { BaseLanguage })
        {
        }
        
        public Receptionist(uint id, string name, decimal salary, List<Languages> collOfLanguages) : base(id, name, salary)
        {
            this.CollOfLanguages = collOfLanguages;
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