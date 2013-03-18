using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelManager.Facility;

namespace HotelManager.Facility
{
    public class SeaHotel : Hotel
    {
        //Prop unique for seahotels
        //beach sides ? Number of sea side spots ?

        public SeaHotel(Category category, byte numberOfPools) : base(category, numberOfPools)
        {

        }
    }
}
