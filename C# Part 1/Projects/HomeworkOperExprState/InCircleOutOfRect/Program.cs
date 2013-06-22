using System;

class InCircleOutOfRect
{
    static void Main()
    {
        int r = 3;
        int topLeft = 1, topRight = topLeft + 6, botLeft = topLeft - 2, botRight = botLeft - 2;
        Console.WriteLine("Enter x = ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter y = ");
        double y = double.Parse(Console.ReadLine());
        bool circle = (((x - 1) * (x - 1)) + ((y - 1) * (y - 1))) <= (r * r);
        bool rectangle = ((x >= topLeft) && (x <= topRight)) && ((y <= botLeft) && (y >= botRight));
        if (circle && (!rectangle))
        {
            Console.WriteLine("The given point with coordinates [{0},{1}] \nis within the circle K(0,5) and the rectangle", x, y);
        }
        else
        {
            Console.WriteLine("The given point with coordinates [{0},{1}] \nis out of the circle K(0,5) and the rectangle", x, y);
        }

    }
}

