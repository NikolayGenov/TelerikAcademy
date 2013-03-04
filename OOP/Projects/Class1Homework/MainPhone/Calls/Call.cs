using System;

namespace MainPhone.Calls
{
    public class Call : IComparable<Call>
    {
        private DateTime time;
        //Should be only numbers
        private long? dialedNumber;
        private int? duration;

        public long? DialedNumber
        {
            get
            {
                return this.dialedNumber;
            }
            set
            {
                //The number should be between 3 and 20 digits
                if ((value != null) && ((value.ToString().Length < 3) || (value.ToString().Length > 20)))
                {
                    throw new ArgumentException("The length of the number is not correct");
                }
                this.dialedNumber = value;
            }
        }

        public int? Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                if ((value != null) && (value < 0))
                {
                    throw new ArgumentException("Time can't be less than 0 seconds");
                }
                this.duration = value;
            }
        }

        public DateTime Time
        {
            get
            {
                return this.time;
            }
            set
            {
                this.time = value;
            }
        }

        public int CompareTo(Call comCall)
        {
            int diff = (int)(this.Duration - comCall.Duration);
           
            return diff;
        }

        public Call(DateTime time, int? duration, long? dialedNumber)
        {
            this.Time = time;
            this.Duration = duration;
            this.DialedNumber = dialedNumber;
        }

        public override string ToString()
        {
            string text = null;
            text += ("Dialed number: " + this.DialedNumber + " \n");
            text += ("Time: " + this.Time + " \n");
            text += ("Duration: " + this.Duration + " \n");
            
            return text;
        }
    }
}