using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelManager.Facility;
using HotelManager.Person;

namespace HotelManager.Facility
{
    //student hostel ?
    public class Hostel : Facility
    {
        public byte NumberOfCookingRooms { get; private set; }

        //number of rooms for students ?
        public Hostel(Category category, byte numberOfCookingRooms = 1) : base(category)
        {
            this.NumberOfCookingRooms = numberOfCookingRooms;
        }
    }
}