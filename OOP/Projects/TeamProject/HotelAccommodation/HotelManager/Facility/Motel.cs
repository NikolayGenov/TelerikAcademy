namespace HotelManager.Facility
{
    public class Motel : Facility
    {
        public byte NumberOfParkingPlaces { get; private set; }

        public Motel(string facilityName, Category category, byte numberOfParkingPlaces=1) : base(facilityName, category)
        {
            this.NumberOfParkingPlaces = numberOfParkingPlaces;
        }
        
    }
}