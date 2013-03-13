using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelManager.Person;

namespace HotelManager.Person
{
    public class Client : Person, IPay
    {
        public void CollectMoney(decimal ammount)
        {
            throw new NotImplementedException();
        }

        public bool RequestMoney(decimal ammount)
        {
            throw new NotImplementedException();
        }

        public decimal PayMoney(decimal ammount)
        {
            throw new NotImplementedException();
        }
    }
}
