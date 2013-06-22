using System;

namespace Abstraction
{
    class Rectangle : Figure
    {
        private double width = 0;
        private double height = 0;

        public Rectangle(double width, double height) 
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The width of the rectangle can't be less than 0");
                }
                else
                {
                    this.width = value;
                }
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The height of the rectangle can't be less than 0");
                }
                else
                {
                    this.height = value;
                }
            }
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}