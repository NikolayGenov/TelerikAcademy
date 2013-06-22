using System;
using MainPhone.Calls;

namespace MainPhone.GsmClass
{
    public class GSM
    {
        //Fields 
        private string model = null;
        private string manufacturer = null;
        private double? price = 0;
        private string owner = null;
        private Battery battery = null;
        private Display display = null;

        // Properties
        public double? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if ((value != null) && value < 0)
                    throw new ArgumentException("Price can't be negative!");
                this.price = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value != null && ((value.Length < 3) || (value.Length > 50)))
                {
                    throw new ArgumentException("The name of the owner must be between 3 and 50 symbols!");
                }
                this.owner = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("There must be a model given");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("There must be a manufacturer given");
                }
                this.manufacturer = value;
            }
        }

        //Static field for IPhone 4s
 
        public static GSM IPhone4S = new GSM("iPhone 4S", "Apple", 599.99, null, new Battery(Battery.BatteryType.NiMH, 50, 8), new Display(3.5, 160000000));

        public static GSM PIPhone4S
        {
            get
            {
                return IPhone4S;
            }
            set
            {
                IPhone4S = value;
            }
        }

        //CallHistory is too big so we can put it in another class
        public CallHistory CallHistory { get; set; }

        //Constructors
        public GSM(string model, string manufacturer) : this(model, manufacturer, null)
        {
        }

        public GSM(string model, string manufacturer, double? price) : this(model, manufacturer, price, null)
        {
        }

        public GSM(string model, string manufacturer, double? price, string owner) : this(model, manufacturer, price, owner, null)
        {
        }

        public GSM(string model, string manufacturer, double? price, string owner, Battery battery) : this(model, manufacturer, price, owner, battery, null)
        {
        }

        public GSM(string model, string manufacturer, double? price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        //Overriding ToString and saving everything in a simple string variable
        public override string ToString()
        {
            string text = null;
            text += ("Model: " + this.Model + " \n");
            text += ("Manufacturer: " + this.Manufacturer + " \n");
            if (this.Price != null)
            {
                text += ("Price: " + this.Price + " \n");
            }
            if (this.Owner != null)
            {
                text += ("Owner: " + this.Owner + " \n");
            }
            if (this.Battery != null)
            {
                text += ("Battery: \t" + this.Battery);
            }
            if (this.Display != null)
            {
                text += ("Display: \t" + this.Display);
            }
            return text;
        }
    }
}