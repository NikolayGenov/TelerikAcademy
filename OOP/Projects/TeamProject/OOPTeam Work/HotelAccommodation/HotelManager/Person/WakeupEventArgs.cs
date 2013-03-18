using System;
using System.Linq;

namespace HotelManager.Person
{
    public class WakeupEventArgs : EventArgs
    {
        //Class to parse parameters with event
        private ushort timer;
        private string clientName;
        public string ClientName
        {
            get
            {
                return clientName;
            }
            set
            {
                clientName = value;
            }
        }

        public ushort Timer
        {
            get
            {
                return timer;
            }
            set
            {
                timer = value;
            }
        }

        public WakeupEventArgs(ushort argument, string name)
        {
            timer = argument;
            clientName = name;
        }
    }
}

    

