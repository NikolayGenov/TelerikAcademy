namespace HotelManager.Facility
{
    public class GolfAndSpa : Hotel
    {
        public GolfFacility GolfField { get; set; }

        public GolfAndSpa(string facilityName, Category category, GolfFacility golfField, byte numberOfPools) : base(facilityName, category, numberOfPools)
        {
            this.GolfField = golfField;
        }
    }
}