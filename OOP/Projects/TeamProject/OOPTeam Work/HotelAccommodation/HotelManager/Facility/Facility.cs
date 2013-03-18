using System;
using System.Collections.Generic;
using System.Linq;
using HotelManager.Person;
using System.Text;

namespace HotelManager.Facility
{
    public abstract class Facility : IAccommodate
    {
        public event EventHandler CleanRoom; //TODO implement event

        public ICollection<Personel> Personel { get; set; }
       
        //Polymorphism (this collection is keeping managers, receptionists, housekeepers, etc.)
        
        public ICollection<Room> Rooms { get; set; }

        public ICollection<Room> TakenRooms { get; set; }

        public Category Category { get; private set; }
        
        public Facility(Category category)
        {
            this.Category = category;
            this.Personel = new List<Personel>();
            this.Rooms = new List<Room>();
        }
        
        public void CreateRoom(Room room, ushort numberToCreate = 1)
        {
            Room oldRoom = room;           
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

        //public virtual void RentRoom(ICollection<Room> rooms, Receptionist recep, Client client, RoomPrice price)
        //{
        //    if (client.RequestMoney(client.PayForRoom((decimal)price)))
        //    {
        //        Console.WriteLine("test");
        //    }
        //    else
        //    {
        //        //Client can't PAY
        //    }
        //}

        public virtual Room CheckIn(ICollection<Person.Client> clients)
        {
            var queryRoom =
                           from room in this.Rooms
                           where room.IsFree && room.IsCleaned && room.Kind == clients.First().RoomToRent
                //Check again
                           select room;
            if (queryRoom.Count() == 0)
            {
                queryRoom =
                           from room in this.Rooms
                           where room.IsFree && room.IsCleaned && (int)room.Kind > (int)clients.First().RoomToRent
                           select room;
            }
            if (queryRoom.Count() == 0)
            {
                throw new FacilityException("No free rooms!");
            }
            Room selectedRoom = queryRoom.First();
            //!!!!!!!!!
            //CHECK THAT !!!

            clients.First().Id = selectedRoom.RoomNumber;

            //When room is CheckedIn - it becomes NOT free and NOT clean
            selectedRoom.IsFree = false;
            selectedRoom.IsCleaned = false;
            selectedRoom.Bill = 0;
            return selectedRoom;
        }

        public virtual decimal CheckOut(Client client)
        {
            decimal bill = 0;
            var queryRoom =
                           from room in this.TakenRooms
                           where client.Id == room.RoomNumber
                           select room;
            if (queryRoom.Count() == 0)
            {
                throw new FacilityException("There is client like that in this room !");
            }
            Room selectedRoom = queryRoom.First();
            selectedRoom.IsCleaned = false;
            // Invoke event CleanRoom(roomnumber)
            selectedRoom.IsFree = true;
            bill = selectedRoom.Bill;
            // FIX BILL THING - remove it somehow
            //****************************
            selectedRoom.Bill = 0;
            return bill;
            //****************************
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