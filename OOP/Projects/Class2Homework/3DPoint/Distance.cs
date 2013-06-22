using System;
using System.Linq;

namespace _3DPoint
{
    public static class Distance
    {
        public static double CalculateDistance(Point first, Point second)
        {
            //Take the square of all the difference between the cordiantes and then take the square root of it to get the final result 
            double pointsSquared = Math.Pow((first.X - second.X), 2) + Math.Pow((first.Y - second.Y), 2) + Math.Pow((first.Z - second.Z), 2);
            double result = Math.Sqrt(pointsSquared);
            return result;
        }
    }
}