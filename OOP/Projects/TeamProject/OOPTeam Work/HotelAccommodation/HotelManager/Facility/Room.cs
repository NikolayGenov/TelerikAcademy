using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Facility
{
    public class Room : ICloneable
    {
        public ushort RoomNumber { get; set; }

        public RoomKind Kind { get; set; }

        public byte NumberOfBeds { get; set; }

        public bool IsFree { get; set; }

        public bool IsCleaned { get; set; }

        public decimal Bill { get; set; }

        public Room()
        {
            this.RoomNumber = 0;
            this.Kind = default(RoomKind);
            this.NumberOfBeds = 0;
            this.IsFree = true;
            this.IsCleaned = true;
            this.Bill = 0;
        }

        public Room(RoomKind kind, byte numberOfBeds) : this()
        {
            this.Kind = kind;
            this.NumberOfBeds = numberOfBeds;
        }
        public object Clone()
        {
            return this.MemberwiseClone();      // call clone method
        }
    }
}