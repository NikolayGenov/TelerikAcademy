using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelManager;
using HotelManager.Person;

namespace HotelManager.Facility
{
    public class Chalet : Facility
    {
        //Ski lifts available ?
        public byte NumberOfSkiLifts { get; private set; }

        public Chalet(Category category, byte numberOfSkiLifts =0) : base(category)
        {
            this.NumberOfSkiLifts = numberOfSkiLifts;
        }
    }
}