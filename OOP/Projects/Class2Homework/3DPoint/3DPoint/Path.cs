using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3DPoint
{
    public class Path
    {
        //Were we save the points
        private List<Point> listOfPoints = new List<Point>();
        
        //Method to add a new point to the list
        public void AddPoint(Point point)
        {
            this.listOfPoints.Add(point);
        }

        //Two constructors
        public Path(Point startPoint)
        {
            this.AddPoint(startPoint);
        }

        public Path()
        {
        }

        //Another overrride to print all the points in the list
        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            foreach (Point point in listOfPoints)
            {
                text.AppendLine(point.ToString());
            }
            return text.ToString();
        }
    }
}