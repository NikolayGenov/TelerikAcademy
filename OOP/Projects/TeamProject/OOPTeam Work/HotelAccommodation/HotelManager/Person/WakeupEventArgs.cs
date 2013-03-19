using System;

namespace HotelManager.Person
{
    public class WakeupEventArgs : EventArgs
    {
        public ushort Timer { get; set; }
        
        public string ClientName { get; set; }
        
        public WakeupEventArgs(ushort timer, string clientName)
        {
            this.Timer = timer;
            this.ClientName = clientName;
        }
    }
}