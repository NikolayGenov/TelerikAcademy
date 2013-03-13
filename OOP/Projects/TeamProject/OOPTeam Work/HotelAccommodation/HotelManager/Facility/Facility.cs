using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Facility
{
    public abstract class Facility : IAccommodate
    {
        public abstract ushort CheckIn(ICollection<Person.Client> clients);

        public abstract decimal CheckOut(ushort roomNumber);
    }
}
