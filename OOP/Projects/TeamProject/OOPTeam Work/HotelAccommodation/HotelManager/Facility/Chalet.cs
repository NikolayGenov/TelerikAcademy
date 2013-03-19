namespace HotelManager.Facility
{
    public class Chalet : Facility
    {
        public byte NumberOfSkiLifts { get; private set; }

        public Chalet(string facilityName, Category category, byte numberOfSkiLifts =0) : base(facilityName, category)
        {
            this.NumberOfSkiLifts = numberOfSkiLifts;
        }
    }
}