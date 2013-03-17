using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelManager.Person;

namespace HotelManager.Person
{
    public class Client : Person
    {
        public Client(uint id, string name, decimal wallet) : base(id, name,wallet)
        {
        }
    }
}