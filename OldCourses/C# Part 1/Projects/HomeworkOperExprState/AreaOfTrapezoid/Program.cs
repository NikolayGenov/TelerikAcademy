using System;

class AreaOfTrapezoid
{
    static void Main()
    {
        double areaOfTrapezoid = 0.0;
        Console.WriteLine("Enter a = ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter b = ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter h = ");
        double h = double.Parse(Console.ReadLine());
        areaOfTrapezoid = ((a + b) * h) / 2.0;
        Console.WriteLine("The area the trapezoid with a= {0} , b= {1} and h= {2} is S= {3}", a, b, h, areaOfTrapezoid);
    }
}

