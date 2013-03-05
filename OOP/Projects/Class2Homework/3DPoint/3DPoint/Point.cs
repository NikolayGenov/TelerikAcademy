using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DPoint
{
    struct Point
    {
        private double x ;
        private double y ;
        private double z ;
        private static readonly Point begin = new Point(0, 0, 0);

        public Point(double x, double y, double z):this()
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
