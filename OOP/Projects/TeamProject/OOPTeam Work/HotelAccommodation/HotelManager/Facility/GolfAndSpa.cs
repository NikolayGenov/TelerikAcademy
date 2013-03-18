using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelManager;

namespace HotelManager.Facility
{
    public class GolfAndSpa : Hotel
    {
        public GolfFacility GolfField { get; set; }

        public GolfAndSpa(Category category, GolfFacility golfField, byte numberOfPools) : base(category, numberOfPools)
        {
            this.GolfField = golfField;
        }
    }
}