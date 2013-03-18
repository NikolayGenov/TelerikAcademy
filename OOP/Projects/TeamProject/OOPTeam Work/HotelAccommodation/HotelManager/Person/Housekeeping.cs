using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelManager.Facility;

namespace HotelManager.Person
{
    public class Housekeeping : Personel
    {
        public Housekeeping(string name, decimal salary) : base(name, salary)
        {
        }
        //Subscribe for events
        public void Subscribe(Receptionist m)
        {
            m.RoomCleanEvent += new Receptionist.RoomEventHandle(this.CleanRoom);
            Console.WriteLine("Waiting for Orders");
        }
        public void CleanRoom(Receptionist sender, RoomEventArgs e) //must be invoked through CleanRoom event. An instance of Housekeeping must be its subscriber
        {
            ushort client = e.ClientID;
            Console.WriteLine("Ok i am going to clean the room");
            if (this.WorkPlace == null)
            {
                throw new PersonException("I'm unemployed! Please hire me!");
            }
            this.WorkPlace.RoomCleaner(client);
            Console.WriteLine("Room cleaned");
        }
        
    }
}