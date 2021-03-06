﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelManager.Person
{
    interface IComunicate
    {
        ICollection<Languages> CollOfLanguages { get; set; }

        string Welcome(Languages langCode); // welcome clients in several languages

        string GoodBye(Languages langCode); // say Good Bye in several languages

        string SayIt(Languages langCode, string phrase); // say some phrases in different languages
    }
}