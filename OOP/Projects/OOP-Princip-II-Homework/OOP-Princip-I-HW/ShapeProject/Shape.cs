using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeProject
{
    public abstract class Shape
    {
        public double Height { get; set; }

        public double Width { get; set; }

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public abstract double CalculateSurface();
    }
}