using System;
using System.Collections.Generic;
using System.Linq;
using HotelManager.Person;
using System.Text;

namespace HotelManager.Facility
{
    public abstract class Facility : IAccommodate
    {
        private readonly Category category;
        private ICollection<Room> rooms;
        private ICollection<Personel> personel; //Polymorphism (this collection is keeping managers, receptionists, housekeepers, etc.)

        public event EventHandler CleanRoom; //TODO implement event
    
        public ICollection<Personel> Personel
        {
            get
            {
                return this.personel;
            }
            set
            {
                this.personel = value;
            }
        }

        public ICollection<Room> Rooms
        {
            get
            {
                return this.rooms;
            }
            set
            {
                this.rooms = value;
            }
        }

        public Category Category
        {
            get
            {
                return this.category;
            }
        }

        public Facility(Category category)
        {
            this.category = category;
            this.Personel = new List<Personel>();
            this.Rooms = new List<Room>();
        }

        private Room RoomCopy(Room room)
        {
            Room newRoom = new Room();
            newRoom.RoomNumber = room.RoomNumber;
            newRoom.Kind = room.Kind;
            newRoom.IsFree = room.IsFree;
            newRoom.IsCleaned = room.IsCleaned;
            newRoom.NumberOfBeds = room.NumberOfBeds;
            return newRoom;
        }

        public void AddRoom(Room room, ushort count = 1)
        {
            ushort roomNumer = 0;
            for (int i = 0; i < count; i++)
            {
                if (this.Rooms.Count > 0)
                {
                    roomNumer = (ushort)(this.Rooms.Last().RoomNumber + 1);
                    room.RoomNumber = roomNumer;
                }
                else
                {
                    room.RoomNumber = 1;
                }
                this.Rooms.Add(RoomCopy(room));
            }
        }

        public void RemoveRoom(ushort roomNumber)
        {
            foreach (var room in this.Rooms.Where(x => x.RoomNumber == roomNumber))
            {
                if (room.IsFree)
                {
                    this.Rooms.Remove(room);
                }
                else
                {
                    throw new FacilityException("This room can't be remooved! It is ocupied!");
                }
            }

        }

        public string ListRooms()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var room in this.Rooms)
	        {
                sb.AppendLine("Room number: " + room.RoomNumber);
                sb.AppendLine("Room kind: " + room.Kind);
                sb.AppendFormat("Room is {0}\n", room.IsFree ? "free" : "ocupied");
                sb.AppendFormat("Room is {0}\n", room.IsCleaned ? "cleaned" : "not cleaned");
                sb.AppendLine(new string('-', 20));
            }
            return sb.ToString();
        }

        public virtual ushort CheckIn(ICollection<Person.Client> clients)
        {
            var queryRoom =
                from room in this.Rooms
                where room.IsFree && room.IsCleaned && room.NumberOfBeds == clients.Count 
                select room;
            if (queryRoom.Count() == 0)
            {
                queryRoom =
                from room in this.Rooms
                where room.IsFree && room.IsCleaned && room.NumberOfBeds > clients.Count
                select room;
            }
            if (queryRoom.Count() == 0)
            {
                throw new FacilityException("No free rooms!");
            }
            Room selectedRoom = queryRoom.First();
            selectedRoom.IsFree = false;
            selectedRoom.Bill = 0;
            return selectedRoom.RoomNumber;
        }

        public virtual decimal CheckOut(ushort roomNumber)
        {
            decimal bill = 0;
            var queryRoom =
                from room in this.Rooms
                where room.RoomNumber == roomNumber
                select room;
            if (queryRoom.Count() == 0)
            {
                throw new FacilityException("There is no room with room number " + roomNumber);
            }
            Room selectedRoom = queryRoom.First();
            selectedRoom.IsCleaned = false;
            // Invoke event CleanRoom(roomnumber)
            selectedRoom.IsFree = true;
            bill = selectedRoom.Bill;
            selectedRoom.Bill = 0;
            return bill;
        }

        public string GetPersonalByType(Type personalType) //Polymorhism implementation (can return list of one category personel or all personel)
        {                                                   //Usage: GetPersonalByType(typeof(Receptionist));
            StringBuilder sb = new StringBuilder();
            foreach (var person in this.Personel)
            {
                if (person.GetType() == personalType || person.GetType().IsSubclassOf(personalType))
                {
                    sb.AppendLine("Name: " + person.Name);
                    sb.AppendLine("ID: " + person.Id);
                    sb.AppendLine("Salary: " + person.Salary);
                    sb.AppendLine(new string('-', 30));
                }
            }
            return sb.ToString();
        }

        public void HirePersonel(Personel person)
        {
            this.Personel.Add(person);
            person.WorkPlace = this;
        }

        public void ReleasePersonel(uint id)
        {
            foreach (var person in this.Personel.Where(x => x.Id == id))
            {
                this.Personel.Remove(person);
                person.WorkPlace = null;
            }
            
        }

        public void RoomCleaner(ushort roomNumber)
        {
            var queryRoom =
                from room in this.Rooms
                where room.RoomNumber == roomNumber
                select room;
            if (queryRoom.Count() == 0)
            {
                throw new FacilityException("There is no room with room number " + roomNumber);
            }
            Room selectedRoom = queryRoom.First();
            selectedRoom.IsCleaned = true;
        }
  
    }
}
