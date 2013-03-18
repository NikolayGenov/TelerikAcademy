using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeProject
{
    public class Triangle : Shape
    {
        public Triangle(double width, double height) : base(width, height)
        {
        }

        public double CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}
