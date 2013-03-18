using System;

namespace ShapeProject
{
    public class Circle : Shape
    {
        //Using only the width
        public Circle(double width) : base(width, width)
        {
            this.Width = width;
            this.Height = width;
        }

        //Again but this time we add PI
        public override double CalculateSurface()
        {
            return this.Width * this.Height * Math.PI;
        }
    }
}