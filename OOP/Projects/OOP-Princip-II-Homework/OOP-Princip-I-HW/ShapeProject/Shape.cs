using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeProject
{
    public abstract class Shape
    {
        private double width;
        private double height;
        
        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }

        public virtual double CalculateSurface()
        {
            return this.Height * this.Width;
        }
    }
}