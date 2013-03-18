using System;
using System.Collections.Generic;
using System.Linq;
using HotelManager.Person;

namespace HotelManager.Facility
{
    public struct GolfFacility
    {
        public int NumberOfHoles { get; set; }
        public byte DificultyLevel { get; set; }
        public List<Personel> Instructors { get; set; }

        public GolfFacility(int numberOfHoles, byte dificultyLevel)
            : this()
        {
            this.NumberOfHoles = numberOfHoles;
            this.DificultyLevel = dificultyLevel;
            this.Instructors = new List<Personel>();
        }
    }
}
