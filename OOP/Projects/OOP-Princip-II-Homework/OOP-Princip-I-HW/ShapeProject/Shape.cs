namespace ShapeProject
{
    public abstract class Shape
    {
        //The base class with abstract method
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