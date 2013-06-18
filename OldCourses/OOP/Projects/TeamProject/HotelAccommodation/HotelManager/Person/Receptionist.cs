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

        public Room CheckIn(Client client)
        {
            if (this.WorkPlace == null)
            {
                throw new PersonException("I'm unemployed! Please hire me!");
            }
            return this.WorkPlace.CheckIn(client);
        }

        public bool CheckOut(Client client)
        {
            if (this.WorkPlace == null)
            {
                throw new PersonException("I'm unemployed! Please hire me!");
            }
            return this.WorkPlace.CheckOut(client);
        }

        public bool GiveRoom(Client client)
        {
            RoomKind clientsRoom = client.RoomToRent;
            if (client.RequestRentRoom(clientsRoom))
            {
                Room takenRoom = this.CheckIn(client);
                this.WorkPlace.TakenRooms.Add(takenRoom);
                this.WorkPlace.CollectMoney(client.PayForRoom());
                return true;
            }
            else
            {
                //Remove person from clients
                this.WorkPlace.Clients.Remove(client);
                return false;
            }
        }

        public string TryCheckOutRoom(Client client)
        {
            StringBuilder info = new StringBuilder();
            if (CheckOut(client))
            {
                info.AppendFormat("The client was checked out successfully").AppendLine();
                //Triger event RoomEventHandle which is reposible to clean the room
                if (this.RoomCleanEvent != null)
                {
                    this.RoomCleanEvent(this, new RoomEventArgs((ushort)client.Id));
                    info.AppendLine("Room was cleaned");
                }
            }
            else
            {
                info.AppendFormat("There is client like that in this room ! - Can't check out").AppendLine();
            }
            return info.ToString();
        }

        public string TryGivingRooms()
        {
            ICollection<Client> clients = this.WorkPlace.Clients;
            StringBuilder info = new StringBuilder();
            foreach (Client client in clients)
            {
                if (GiveRoom(client))
                {
                    info.AppendFormat("The room with number {0} was given to a client", this.WorkPlace.TakenRooms.Last().RoomNumber).AppendLine();
                }
                else
                {
                    info.AppendFormat("The client doens't have enough money and was removed from the list of clients").AppendLine();
                }
            }
            return info.ToString();
        }

        //Method used to triger the event WakeupCallEvent used for WakeUpCall
        public void WakeUpCall(ushort timer, Client requestor)
        {
            //Subsrcibe for event
            this.WakeupCallEvent += new Receptionist.CustomEventHandler(AlarmClock);
            if (this.WakeupCallEvent != null)
            {
                //Triger event
                this.WakeupCallEvent(this, new WakeupEventArgs(timer, requestor.Name));
            }
        }

        //Method called by the event
        public void AlarmClock(Receptionist sender, WakeupEventArgs eventParam)
        {
            Console.WriteLine("Wakeup call requested after {0} hours", eventParam.Timer);
            string name = eventParam.ClientName;
            DateTime currentDate = DateTime.Now;
            currentDate = currentDate.AddHours((double)eventParam.Timer);
            ushort start = eventParam.Timer;
            Thread.Sleep(start * 1000);
            Console.WriteLine("Wakeup Mr {0} it is {1:t}", name, currentDate);
        }

        //Delegates for custom event to parse parameters with event
        public delegate void CustomEventHandler(Receptionist publisherClass, WakeupEventArgs eventParams);

        public delegate void RoomEventHandle(Receptionist publisherClass, RoomEventArgs eventParams);

        //Custom events
        public event CustomEventHandler WakeupCallEvent;
        public event RoomEventHandle RoomCleanEvent; 
    }
}