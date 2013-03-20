using System;


namespace HotelManager.Person
{
    public class Housekeeping : Personel
    {
        public Housekeeping(string name, decimal salary) : base(name, salary)
        {
        }

        //Subscribe for events
        public void WaitingForOders(Receptionist recep)
        {
            recep.RoomCleanEvent += new Receptionist.RoomEventHandle(this.CleanRoom);
        }

        public void CleanRoom(Receptionist recepSender, RoomEventArgs client) 
        {
            //Because the room number matches the client ID
            ushort roomNumber = client.ClientID;
            if (this.WorkPlace == null)
            {
                throw new PersonException("I'm unemployed! Please hire me!");
            }
            this.WorkPlace.RoomCleaner(roomNumber);
        }
    }
}