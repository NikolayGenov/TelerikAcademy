using System;
using System.Linq;

namespace HotelManager.Person
{
    public class RoomEventArgs
    {
        public ushort ClientID { get ; set ; }

        public RoomEventArgs(ushort client)
        {
            ClientID = client;
        }
    }
}