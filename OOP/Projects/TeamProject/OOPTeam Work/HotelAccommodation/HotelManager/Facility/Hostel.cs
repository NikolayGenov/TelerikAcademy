namespace HotelManager.Facility
{
    public class Hostel : Facility
    {
        public byte NumberOfCookingRooms { get; private set; }

        public Hostel(string facilityName, Category category, byte numberOfCookingRooms = 1) : base(facilityName, category)
        {
            this.NumberOfCookingRooms = numberOfCookingRooms;
        }
        
    }
}