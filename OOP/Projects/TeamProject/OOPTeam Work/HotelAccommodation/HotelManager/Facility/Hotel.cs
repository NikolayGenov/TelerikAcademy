using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelManager.Facility;
using HotelManager.Person;

namespace HotelManager.Facility
{
    public class Hotel : Facility
    {
        public byte NumberOfPools { get; private set; }

        public Hotel(Category category, byte numberOfPools =1) : base(category)
        {
            this.NumberOfPools = numberOfPools;
        }
    }
}