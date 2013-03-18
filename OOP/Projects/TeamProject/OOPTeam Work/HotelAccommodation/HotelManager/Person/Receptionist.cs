using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelManager.Facility;

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

        public Room CheckIn(ICollection<Client> clients)
        {
            if (this.WorkPlace == null)
            {
                throw new PersonException("I'm unemployed! Please hire me!");
            }
            return this.WorkPlace.CheckIn(clients);
        }

        public decimal CheckOut(Client client)
        {
            if (this.WorkPlace == null)
            {
                throw new PersonException("I'm unemployed! Please hire me!");
            }
            return this.WorkPlace.CheckOut(client);
        }

        public void GiveRoom(ICollection<Client> clients, RoomPrice price)
        {
            //Client client = clients.First();
            if (clients.First().RequestRentRoom(price))
            {
                Room takenRoom = this.CheckIn(clients);
                this.WorkPlace.TakenRooms.Add(takenRoom);
                this.CollectMoney(clients.First().PayForRoom((decimal)price));
            }
            else
            {
                clients.Remove(clients.First());
                //Remove it from clients
            }
        }

        public event EventHandler WakeUpCall; //TODO implement the event
    }
}