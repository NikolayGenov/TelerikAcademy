using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DPoint
{
   public static class Distance
    {
       public static double CalculateDistance(Point first, Point second)
       {
           double pointsSquared = Math.Pow((first.X - second.X), 2) + Math.Pow((first.Y - second.Y), 2) + Math.Pow((first.Z - second.Z), 2);
           double result = Math.Sqrt(pointsSquared);
           return result;
       }
    }
}
