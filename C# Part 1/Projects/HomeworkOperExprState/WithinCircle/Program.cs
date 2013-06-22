using System;


class WithinCircle
{
    static void Main()
    {
        int r = 5;
        Console.WriteLine("Enter x = ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter y = ");
        int y = int.Parse(Console.ReadLine());
        if (((x * x) + (y * y)) <= (r * r))
        {
            Console.WriteLine("The given point with coordinates [{0},{1}] is within the circle K(0,5)", x, y);
        }
        else
        {
            Console.WriteLine("The given point with coordinates [{0},{1}] is out of the circle K(0,5)", x, y);
        }
    }
}
