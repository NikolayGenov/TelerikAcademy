using System;

class CalculateAreaOfRectangle
{
    static void Main()
    {
        double areaOfRectangle = 0.0;
        Console.WriteLine("Enter width : ");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter height : ");
        double height = double.Parse(Console.ReadLine());
        areaOfRectangle = width * height;
        Console.WriteLine("The area of the rectangle with width {0} and height {1} is {2} sqr cm", width, height, areaOfRectangle);
        
    }
}

