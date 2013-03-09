using System;
using System.Linq;

namespace _3DPoint
{
    public class Tests
    {
        static void Main()
        {
            //File path to the test file with the points
            string filePath = "..//..//text.txt";
            //Add 1 point
            Point p1 = new Point(3.5, 4.6, 3);
            //Calculate the distance between the point and the start point  (0,0,0)
            double distance = Distance.CalculateDistance(p1, Point.Begin);
            Console.WriteLine("The distance betweem {0} and {1} is {2}", p1.ToString(), Point.Begin.ToString(), distance);

            //Create a path and then add few points to it
            Path path = new Path(Point.Begin);
            path.AddPoint(new Point(9, 5, 1));
            path.AddPoint(new Point(4, 6.3, 9.0));
            path.AddPoint(new Point(3.4, 9.0, 7.1));
            path.AddPoint(new Point(7.2, 1.4, 0.1));
            
            //Print the Path using the ToString            
            Console.WriteLine("Path:\n{0}", path.ToString());

            //Save the path with those points in the file 
            PathStorage.SavePoints(path, filePath);
            
            //Create a new path and then load to a new path the data from the file
            Path newPath = new Path();
            newPath = PathStorage.LoadPath(filePath);
            //Then add a new point to the new path
            newPath.AddPoint(p1);
            Console.WriteLine("New Path:\n{0}", newPath.ToString());
            //Finally we write the new path to the file
            PathStorage.SavePoints(newPath, filePath);
        }
    }
}