namespace ShapeProject
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height) : base(width, height)
        {
        }

        //override of the class to return some actual value
        public override double CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}