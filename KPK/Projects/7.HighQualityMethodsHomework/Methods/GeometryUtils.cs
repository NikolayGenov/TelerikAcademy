using System;

namespace Methods
{
    public class GeometryUtils
    {
        public static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("All sides must be positive!");
            }
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("The given sides can't form valid triangle");
            }
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        public static double CalcDistance(double x1, double x2, double y1, double y2)
        {
            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return distance;
        }

        public static bool IsHorizontalLine(double x1, double x2, double y1, double y2)
        {
            if (IsPoint(x1, x2, y1, y2))
            {
                throw new ArgumentException("The points can't form a line");
            }
            return y1 == y2;
        }

        public static bool IsVerticalLine(double x1, double x2, double y1, double y2)
        {
            if (IsPoint(x1, x2, y1, y2))
            {
                throw new ArgumentException("The points can't form a line");
            }
            return x1 == x2;
        }

        private static bool IsPoint(double x1, double x2, double y1, double y2)
        {
            return x1 == x2 && y1 == y2;
        }
    }
}