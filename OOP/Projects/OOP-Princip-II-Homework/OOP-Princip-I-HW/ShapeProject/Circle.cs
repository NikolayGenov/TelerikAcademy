using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeProject
{
    public class Circle : Shape
    {
        public Circle(double width, double height) : base(width, height)
        {
            this.Width = width;
            this.Height = width;
            //CHECK THAT!!!!!!!
            //TO DO
        }

        public double CalculateSurface()
        {
            return this.Width * this.Height * Math.PI;
        }
    }
}