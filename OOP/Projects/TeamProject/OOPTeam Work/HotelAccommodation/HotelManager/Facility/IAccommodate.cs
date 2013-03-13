using System;
using System.Collections.Generic;
using System.Linq;
using HotelManager.Person;

namespace HotelManager.Facility
{
    interface IAccommodate
    {
        ushort CheckIn(ICollection<Client> clients); //returns Room Number in which clients were accomodated
        decimal CheckOut(ushort roomNumber); // returns ammount of money if some services are not paid
    }
}
