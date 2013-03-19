namespace HotelManager.Facility
{
    public class Hotel : Facility
    {
        public byte NumberOfPools { get; private set; }

        public Hotel(string facilityName, Category category, byte numberOfPools = 1) : base(facilityName, category)
        {
            this.NumberOfPools = numberOfPools;
        }
        
    }
}