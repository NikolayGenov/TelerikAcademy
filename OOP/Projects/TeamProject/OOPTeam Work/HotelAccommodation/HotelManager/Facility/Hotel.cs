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
        public Hotel(Category category) 
            : base(category)
        {
        }
    }
}
