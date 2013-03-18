using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelManager.Facility;
using HotelManager.Person;

namespace HotelManager.Facility
{
    public class Motel : Facility
    {
        public byte NumberOfParkingPlaces { get; private set; }

        public Motel(Category category, byte numberOfParkingPlaces=1) : base(category)
        {
            this.NumberOfParkingPlaces = numberOfParkingPlaces;
        }
    }
}