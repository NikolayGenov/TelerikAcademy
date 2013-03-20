using System;
using System.Collections.Generic;
using System.Linq;
using HotelManager.Person;
using System.Text;

namespace HotelManager.Facility
{
    public abstract class Facility : IAccommodate
    {
        public ICollection<Personel> Personel { get; set; }
       
        //Polymorphism (this collection is keeping managers, receptionists, housekeepers, etc.)
        
        public ICollection<Room> Rooms { get; set; }

        public ICollection<Room> TakenRooms { get; set; }

        public ICollection<Client> Clients { get; set; }

        public decimal Finance { get; set; }

        public string FacilityName { get; set; }

        public Category Category { get; private set; }
        
        public Facility(string facilityName, Category category)
        {
            this.FacilityName = facilityName;
            this.Finance = 0m;
            this.Category = category;
            this.Personel = new List<Personel>();
            this.Rooms = new List<Room>();
            this.TakenRooms = new List<Room>();
            this.Clients = new List<Client>();
        }
        
        public void CreateRoom(Room room, ushort numberToCreate = 1)
        {
            Room oldRoom = new Room(room.Kind);        
            ushort roomNumber = (this.Rooms.Count > 0) ? Rooms.Last().RoomNumber : (ushort)0;
            oldRoom.RoomNumber = roomNumber;
            for (int i = 0; i < numberToCreate; i++)
            {
                if (i >= 1)
                {
                    oldRoom = (Room)Rooms.Last().Clone();
                }
                this.Rooms.Add(oldRoom);                
                oldRoom.RoomNumber++;
            }
        }

        public void AddRoomsToFacility(Room room, ushort numberToCreate = 1)
        {
            this.CreateRoom(room, numberToCreate);
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
                    throw new FacilityException("This room can't be removed! It is ocupied!");
                }
            }
        }

        public string ListRooms()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("List of all rooms: ").AppendLine();
            foreach (var room in this.Rooms)
            {
                info.AppendLine("Room number: " + room.RoomNumber);
                info.AppendLine("Room kind: " + room.Kind);
                info.AppendFormat("Room is {0}\n", room.IsFree ? "free" : "occupied");
                info.AppendFormat("Room is {0}\n", room.IsCleaned ? "cleaned" : "not cleaned");
                info.AppendLine(new string('-', 20));
            }
            return info.ToString();
        }

        public string ListTakenRooms()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("List of taken rooms: ").AppendLine();
            foreach (var room in this.TakenRooms)
            {
                info.AppendLine("Room number: " + room.RoomNumber);
                info.AppendLine("Room kind: " + room.Kind);
                info.AppendLine(new string('-', 20));
            }
            return info.ToString();
        }

        public virtual Room CheckIn(Client client)
        {
            //Using LINQ to selecte the room needed for check-in
            var queryRoom =
                           from room in this.Rooms
                           where room.IsFree && room.IsCleaned && room.Kind == client.RoomToRent
                           select room;
            if (queryRoom.Count() == 0)
            {
                queryRoom =
                           from room in this.Rooms
                           where room.IsFree && room.IsCleaned && (int)room.Kind > (int)client.RoomToRent
                           select room;
            }
            if (queryRoom.Count() == 0)
            {
                throw new FacilityException("No free rooms!");
            }
            Room selectedRoom = queryRoom.First();
            client.Id = selectedRoom.RoomNumber;
            //When room is CheckedIn - it becomes NOT free and NOT clean
            selectedRoom.IsFree = false;
            selectedRoom.IsCleaned = false;
            return selectedRoom;
            //Returns the room
        }

        public virtual bool CheckOut(Client client)
        {
            //Returns bool if the room is checked-out successfully
            var queryRoom =
                           from room in this.TakenRooms
                           where client.Id == room.RoomNumber
                           select room;
            if (queryRoom.Count() == 0)
            {
                try
                {
                    throw new FacilityException("There is client like that in this room !");
                }
                catch
                {
                    return false;
                }
            }
            Room selectedRoom = queryRoom.First();
            //Room is setted to free but not clean
            selectedRoom.IsCleaned = false;
            selectedRoom.IsFree = true;
            client = null;
            //Delete the client
            //Remove the room from the list of taken rooms
            this.TakenRooms.Remove(selectedRoom);
            return true;
        }
        
        public string GetPersonalByType(Type personalType) //Polymorhism implementation (can return list of one category personel or all personel)
        { //Usage: GetPersonalByType(typeof(Receptionist));
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

        public virtual void HirePersonel(Personel person)
        {
            this.Personel.Add(person);
            person.WorkPlace = this;
        }

        public virtual void ReleasePersonel(uint id)
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
                           where !(room.IsCleaned ||
                                   (this.TakenRooms.Contains(room))) && (room.RoomNumber == roomNumber)
                           select room;
            if (queryRoom.Count() == 0)
            {
                throw new FacilityException("The room is taken or it's already clean ");
            }
            Room selectedRoom = queryRoom.First();
            selectedRoom.IsCleaned = true;
        }

        public void CollectMoney(decimal ammount)
        {
            this.Finance += ammount;
        }
    }
}