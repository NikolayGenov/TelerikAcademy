using System;
using System.Collections.Generic;
using System.Linq;
using HotelManager.Person;

namespace HotelManager.Facility
{
    interface IAccommodate
    {
        Room CheckIn(ICollection<Client> clients); //returns Room Number in which clients were accomodated
        bool CheckOut(Client client); // returns ammount of money if some services are not paid
    }
}
