using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelManager.Facility;
using HotelManager.Person;

namespace HotelManager.Facility
{
    public class Hostel : Facility
    {
        public Hostel(Category category) 
            : base(category)
        {
        }
    }
}
