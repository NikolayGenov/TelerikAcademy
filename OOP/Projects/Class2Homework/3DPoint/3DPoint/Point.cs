using System;
using System.Linq;

namespace _3DPoint
{
    public struct Point
    {
        //Fields
        private double x ;
        private double y ;
        private double z ;
        private static readonly Point begin = new Point(0, 0, 0);

        //The basic constructor
        public Point(double x, double y, double z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        //The prop for the begin point
        public static Point Begin
        {
            get
            {
                return begin;
            }
        }

        //Prop for all the cordinates
        public double Z
        {
            get
            {
                return this.z;
            }
            set
            {
                this.z = value;
            }
        }

        public double Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

        public double X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        //Overriding the ToString with some formating
        public override string ToString()
        {
            string text = null;
            text = string.Format("[{0},{1},{2}]", this.X, this.Y, this.Z);
            return text;
        }
    }
}