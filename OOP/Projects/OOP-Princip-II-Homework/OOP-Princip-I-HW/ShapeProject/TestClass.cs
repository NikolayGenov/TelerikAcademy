using System;

namespace ShapeProject
{
    class TestClass
    {
        static void Main(string[] args)
        {
            Shape[] arrayOfShapes = new Shape[]
            {
                new Rectangle(4.5, 2.4),
                new Triangle(9.3, 3.1),
                new Circle(6)
            };
            foreach (Shape shape in arrayOfShapes)
            {
                Console.WriteLine("{0} - Surface: {1} ", shape.GetType().Name, shape.CalculateSurface());
            }
        }
    }
}