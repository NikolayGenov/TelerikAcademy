namespace ShapeProject
{
    public class Triangle : Shape
    {
        public Triangle(double width, double height) : base(width, height)
        {
        }
        //Same here
        public override double CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}