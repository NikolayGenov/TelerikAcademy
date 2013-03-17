using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelManager.Facility;

namespace HotelManager.Person
{
    public class Housekeeping : Personel
    {
        
        public Housekeeping(uint id, string name, decimal salary) : base(id, name, salary)
        {
        }

        public void CleanRoom(ushort roomNumber) //must be invoked through CleanRoom event. An instance of Housekeeping must be its subscriber
        {
            if (this.WorkPlace == null)
            {
                throw new PersonException("I'm unemployed! Please hire me!");
            }
            this.WorkPlace.RoomCleaner(roomNumber);
        }
    }
}