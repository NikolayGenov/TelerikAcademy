using System;

namespace MainPhone.GsmClass
{ 
    public class Display
    {
        //Max and Min size of the display in inches
        private const int MinSizeInInches = 1;
        private const int MaxSizeInInches = 10;
        private double? size;
        
        private long? numberOfColors;

        //Can't be negative        
        public long? NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if ((value != null) && value < 0)
                    throw new ArgumentException("Hours can't be negative!");
                this.numberOfColors = value;
            }
        }

        // Properties
        public double? Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if ((value != null) && (value < MinSizeInInches || value > MaxSizeInInches))
                    throw new ArgumentException("This is not a size (in inches) valid for a phone!");
                this.size = value;
            }
        }

        public Display() : this(null)
        {
        }

        public Display(double? size) : this(size, null)
        {
        }

        public Display(double? size, long? numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        //Overridin toString and saving the result in a string and then returting it to the GSM class
        public override string ToString()
        {
            string text = null;

            if (this.Size != null)
            {
                text += ("Size (inches): " + this.Size + "\t");
            }
            if (this.NumberOfColors != null)
            {
                text += ("NumberOfColors: " + this.NumberOfColors + " \n");
            }

            return text;
        }
    }
}