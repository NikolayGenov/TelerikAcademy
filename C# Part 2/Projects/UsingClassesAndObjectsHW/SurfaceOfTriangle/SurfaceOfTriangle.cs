using System;

class SurfaceOfTriangle
{
    static void Main()
    {
        //User menu input
        Console.WriteLine("Press the corresponding number to each different method");
        Console.WriteLine("1 : Side and an altitude to it");
        Console.WriteLine("2 : Three sides");
        Console.WriteLine("3 : Two sides and an angle between them");
        Console.WriteLine("Enter a number from 1 to 3: ");
        //Chosing number from 1 to 3 using switch and cases for each method 
        int n = int.Parse(Console.ReadLine());
        switch (n)
        {
            case 1:
                SideAndAlt();
                break;
            case 2:
                ThereSides();
                break;
            case 3:
                TwoSidesAndAngle();
                break;
            default:
                Console.WriteLine("Incorrect input");
                break;
        }
    }
  
    private static void TwoSidesAndAngle()
    {
        //Take 2 numbers and then the angle , convert the number to radians and then use the formula a*b * sin(x)
        Console.WriteLine("Enter the width of 'a' ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the width of 'b ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the angle between them in degrees");
        double angle = double.Parse(Console.ReadLine());
        double rad = (Math.PI * angle / 180);
        double area = a * b * Math.Sin(rad) / 2;
        PrintArea(area);
    }
  
    private static void ThereSides()
    {
        //Taking a ,b and c , check if they make a triangle that is valid and then use the Heron formula
        Console.WriteLine("Enter the width of 'a' ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the width of 'b ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the width of 'c' ");
        double c = double.Parse(Console.ReadLine());
        if ((a + b > c) && (a + c > b) && (b + c > a))
        {
            double p = (a + b + c) / 2.0;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            PrintArea(area);
        }
        else
        {
            Console.WriteLine("The numbers you have entered can't make a triangle");
        }
    }
  
    private static void SideAndAlt()
    {
        //Using a simple formula - a * ha /2 but we must be sure that it will return a double so we put 2.0
        Console.WriteLine("Enter the width of the side");
        double side = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height of the altitude");
        double h = double.Parse(Console.ReadLine());
        double area = (side * h) / 2.0;
        PrintArea(area);
    }

    private static void PrintArea(double area)
    {
        //Simply print the area
        Console.WriteLine("The area of the triangle is : {0} units^2", area);
    }
}