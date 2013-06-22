using System;

namespace Abstraction
{
    abstract class Figure
    {
        public virtual double CalcPerimeter()
        {
            double perimeter = 0;
            return perimeter;
        }

        public virtual double CalcSurface()
        {
            double surface = 0;
            return surface;
        }
    }
}