using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Point
{
    struct Point
    {
        private double x = 0;
        private double y = 0;
        private double z = 0;
        private static readonly Point begin = new Point(0,0,0);
      
        public Point(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point Begin
        {
            get
            {
                return begin;
            }
        }

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

        public override string ToString()
        {
            string text = null;
            text = string.Format("Point = [{0},{1},{2}]", this.X, this.Y, this, Z);
            return text;
        }

        static void Main(string[] args)
        {
        }
    }
}