using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelManager.Person;
using HotelManager.Facility;

namespace HotelManager.Person
{
    public class Client : Person
    {
        public byte EducationLevel { get; set; }

        public RoomKind RoomToRent { get; private set; }
        
        //Make person ID not so unique and that can be given to corresponding number of the room
        //****************************
        public Client(string name, decimal wallet, RoomKind room = RoomKind.Single) : base(name, wallet)
        {
            this.Id = 0;
            this.EducationLevel = 0;
            this.RoomToRent = room;
        }

        public decimal PayForRoom(decimal pricePerRoom)
        {
            this.Wallet -= pricePerRoom * (int)RoomToRent;
            return pricePerRoom * (int)RoomToRent;
        }

        public decimal CanPayForRoom(decimal pricePerRoom)
        {
            return pricePerRoom * (int)RoomToRent;
        }

        public bool RequestRentRoom(RoomPrice price)
        {
            bool canPay = false;
            if (this.RequestMoney(this.CanPayForRoom((decimal)price)))
            {
                canPay = true;
                return canPay; 
            }
            else
            {
                return canPay;
            }
        }
    }
}