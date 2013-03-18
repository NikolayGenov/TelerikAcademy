using System;

namespace ShapeProject
{
    class TestClass
    {
        static void Main(string[] args)
        {
            //Array of shapes
            Shape[] arrayOfShapes = new Shape[]
            {
                //Then create some chapes with random params
                new Rectangle(4.5, 2.4),
                new Triangle(9.3, 3.1),
                new Circle(6)
            };
            //Print the info for each method call 
            foreach (Shape shape in arrayOfShapes)
            {
                Console.WriteLine("{0} - Surface: {1} ", shape.GetType().Name, shape.CalculateSurface());
            }
        }
    }
}