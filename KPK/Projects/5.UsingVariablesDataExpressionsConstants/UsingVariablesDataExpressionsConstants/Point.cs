using System;

/// <summary>
/// Stores a point of a given object with X and Y properties and can be rotated with a given angle.
/// </summary>
public class Point
{
    public Point(double x, double y)
    {
        this.X = x;
        this.Y = y;
    }

    public double X { get; private set; }

    public double Y { get; private set; }

    public static Point Rotate(Point point, double rotationAngle)
    {
        double cosAngle = Math.Abs(Math.Cos(rotationAngle));
        double sinAngle = Math.Abs(Math.Sin(rotationAngle));
        double newX = (cosAngle * point.X) + (sinAngle * point.Y);
        double newY = (sinAngle * point.X) + (cosAngle * point.Y);
        Point rotatedPoint = new Point(newX, newY);
        return rotatedPoint;        
    }
}