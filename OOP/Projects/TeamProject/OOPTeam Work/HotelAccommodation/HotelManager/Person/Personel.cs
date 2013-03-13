using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelManager.Person;

namespace HotelManager.Person
{
    public class Personel : Person, IComunicate
    {
        public string Welcome(Languages langCode)
        {
            throw new NotImplementedException();
        }

        public string GoodBye(Languages langCode)
        {
            throw new NotImplementedException();
        }

        public string SayIt(Languages langCode, string phrase)
        {
            throw new NotImplementedException();
        }
    }
}
