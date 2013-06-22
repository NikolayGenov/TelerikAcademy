namespace HotelManager.Facility
{
    public class SeaHotel : Hotel
    {
        public int NumberOfBeachSpots { get; set; }

        public SeaHotel(string facilityName, Category category, byte numberOfPools, int numberOfBeachSpots = 100) : base(facilityName, category, numberOfPools)
        {
            this.NumberOfBeachSpots = numberOfBeachSpots;
        }
        
    }
}