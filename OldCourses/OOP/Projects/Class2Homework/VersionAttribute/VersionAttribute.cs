using System;

namespace VersionAttribute
{
    [AttributeUsage(AttributeTargets.Struct |
                    AttributeTargets.Class |
                    AttributeTargets.Interface |
                    AttributeTargets.Enum |
                    AttributeTargets.Method)]

    class VersionAttribute : System.Attribute
    {
        //Using double for numbers only
        private double version;

        public double Version
        {
            get
            {
                return this.version;
            }
            set
            {
                this.version = value;
            }
        }

        //Constructor
        public VersionAttribute(double version)
        {
            this.Version = version;
        }
    }
}