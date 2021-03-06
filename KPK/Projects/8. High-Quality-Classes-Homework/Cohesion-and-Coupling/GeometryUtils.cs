﻿using System;

namespace CohesionAndCoupling
{
    class GeometryUtils
    {
        public static double CalcDistance3D(double x1, double x2, double y1, double y2, double z1, double z2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
            return distance;
        }

        public static double CalcDiagonal3DShape(double width, double height, double depth)
        {
            double distance = CalcDistance3D(0, width, 0, height, 0, depth);
            return distance;
        }

        public static double CalcVolume(double width, double height, double depth)
        {
            double volume = width * height * depth;
            return volume;
        }

        public static double CalcDistance2D(double x1, double x2, double y1, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        public static double CalcDiagonal2DShape(double x, double y)
        {
            double distance = CalcDistance2D(0, x, 0, y);
            return distance;
        }
    }
}