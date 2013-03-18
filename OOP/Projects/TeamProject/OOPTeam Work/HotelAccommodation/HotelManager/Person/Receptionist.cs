using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelManager.Facility;
using System.Threading;

namespace HotelManager.Person
{
    public class Receptionist : Personel
    {
        public Receptionist(string name, decimal salary) : this(name, salary, new List<Languages> { BaseLanguage })
        {
        }
        
        public Receptionist(string name, decimal salary, List<Languages> collOfLanguages) : base(name, salary)
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

        public bool CheckOut(Client client)
        {
            if (this.WorkPlace == null)
            {
                throw new PersonException("I'm unemployed! Please hire me!");
            }
            return this.WorkPlace.CheckOut(client);
        }

        public bool GiveRoom(ICollection<Client> clients)
        {
            //Client client = clients.First();
            if (clients.First().RequestRentRoom((RoomPrice)clients.First().RoomToRent))
            {
                Room takenRoom = this.CheckIn(clients);
                this.WorkPlace.TakenRooms.Add(takenRoom);
                this.CollectMoney(clients.First().PayForRoom((decimal)(RoomPrice)clients.First().RoomToRent));
                return true;
            }
            else
            {
                clients.Remove(clients.First());
                return false;
            }
            //Remove it from clients
        }

        public string TryCheckOutRoom(Client client)
        {
            StringBuilder info = new StringBuilder();
            if (CheckOut(client))
            {
                info.AppendFormat("The client was checked out successfully").AppendLine();
            }
            else
            {
                info.AppendFormat("There is client like that in this room ! - Can't check out").AppendLine();
            }

            return info.ToString();
        }

        public string TryGivingRoom(ICollection<Client> clients)
        {
            StringBuilder info = new StringBuilder();
            if (GiveRoom(clients))
            {
                info.AppendFormat("The room with number {0} was given to a client", this.WorkPlace.TakenRooms.Last().RoomNumber).AppendLine();
            }
            else
            {
                info.AppendFormat("The client doens't have enough money and was removed from the list of clients").AppendLine();
            }

            return info.ToString();
        }
        //Method used to triger the event
        //public void WakeUpCall(ushort timer, Client requestor)
        //{
        //    this.WakeupCallEvent += new Receptionist.CustomEventHandler(AlarmClock);
        //    if (this.WakeupCallEvent != null)
        //    {
        //        this.WakeupCallEvent(this, new WakeupEventArgs(timer, requestor.Name));
        //    }
        //}
        ////Method called by the event
        //public void AlarmClock(Receptionist sender, WakeupEventArgs e)
        //{
        //    Console.WriteLine("Wakeup call requested after {0} hours",e.Timer);
        //    string name = e.ClientName;
        //    DateTime currentDate = DateTime.Now;
        //    currentDate = currentDate.AddHours((double)e.Timer);
        //    ushort start = e.Timer;
        //    Thread.Sleep(start * 1000);
        //    Console.WriteLine("Wakeup Mr {0} it is {1:t}", name,currentDate);
        //}
        ////Delegate for custom event
        //public delegate void CustomEventHandler(Receptionist re, WakeupEventArgs e);
        ////Custom event
        //public event CustomEventHandler WakeupCallEvent;
    }
}