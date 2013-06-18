using System;

class PrintPerAndArea
{
    static void Main()
    {
        Console.WriteLine("Enter r =");
        double r = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * r;
        double area = Math.PI * r * r;
        Console.WriteLine("For a circle with r = {0}, the perimeter is {1:0.000}, and the area is {2:0.000}", r, perimeter, area);
    }
}

