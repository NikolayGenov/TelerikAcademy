using System;

namespace HotelManager.Facility
{
    public class Room : ICloneable
    {
        public ushort RoomNumber { get; set; }

        public RoomKind Kind { get; set; }

        public int NumberOfBeds { get; set; }

        public bool IsFree { get; set; }

        public bool IsCleaned { get; set; }

        public Room()
        {
            this.RoomNumber = 0;
            this.Kind = default(RoomKind);
            this.NumberOfBeds = 0;
            this.IsFree = true;
            this.IsCleaned = true;
        }

        public Room(RoomKind kind) : this()
        {
            this.Kind = kind;      
            this.NumberOfBeds = (int)(double)kind / (int)RoomKind.Single;
        }

        public object Clone()
        {
            return this.MemberwiseClone();     
        }
    }
}