using System;

namespace MainPhone.GsmClass
{ 
    public class Battery
    { 
        //The types of battery made with enum
        public enum BatteryType
        {
            LiIon,
            NiMH,
            NiCd,
            ZnChl
        }
        
        private BatteryType model;
        private double? hoursIdle;
        private double? hoursTalk;

        // Properties
        public BatteryType Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public double? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if ((value != null) && value < 0)
                    throw new ArgumentException("Hours can't be negative!");
                this.hoursIdle = value;
            }
        }

        public double? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if ((value != null) && value < 0)
                    throw new ArgumentException("Hours can't be negative!");
                this.hoursTalk = value;
            }
        }

        //Constructors
        public Battery(BatteryType model) : this(model, null)
        {
        }

        public Battery(BatteryType model, double? hoursIdle) : this(model, hoursIdle, null)
        {
        }

        public Battery(BatteryType model, double? hoursIdle, double? hoursTalk)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        //Overridin toString and saving the result in a string and then returting it to the GSM class
        public override string ToString()
        {
            string text = null;
            text += ("Battery Type: " + this.Model + " \n");

            if (this.HoursIdle != null)
            {
                text += ("HoursIdle: " + this.HoursIdle + " \n");
            }
            if (this.HoursTalk != null)
            {
                text += ("HoursTalk: " + this.HoursTalk + " \n");
            }
            
            return text;
        }
    }
}