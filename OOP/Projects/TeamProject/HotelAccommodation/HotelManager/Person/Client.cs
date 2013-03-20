using HotelManager.Facility;

namespace HotelManager.Person
{
    public class Client : Person
    {
        public byte EducationLevel { get; set; }

        public RoomKind RoomToRent { get; set; }
        
        public Client(string name, decimal wallet, RoomKind room) : base(name, wallet)
        {
            this.Id = 0;
            this.EducationLevel = 0;
            this.RoomToRent = room;
        }

        public decimal PayForRoom()
        {
            this.Wallet -= (decimal)this.RoomToRent;
            return (decimal)this.RoomToRent;
        }
        
        public decimal CanPayForRoom()
        {
            return (decimal)this.RoomToRent;
        }

        public bool RequestRentRoom(RoomKind price)
        {
            bool canPay = false;
            if (this.RequestMoney(this.CanPayForRoom()))
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