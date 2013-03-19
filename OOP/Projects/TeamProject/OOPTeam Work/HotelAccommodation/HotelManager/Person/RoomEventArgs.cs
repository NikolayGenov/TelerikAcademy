using System;
using System.Linq;

namespace HotelManager.Person
{
    public class RoomEventArgs
    {
        //Class to parse parameters with event
        public ushort ClientID { get ; set ; }

        public RoomEventArgs(ushort clientId)
        {
            ClientID = clientId;
        }
    }
}