using System;
namespace ShapeProject
{
    public class Circle : Shape
    {
        public Circle(double width) : base(width, width)
        {
            this.Width = width;
            this.Height = width;
        }
        
        public override double CalculateSurface()
        {
            return this.Width * this.Height * Math.PI;
        }
    }
}