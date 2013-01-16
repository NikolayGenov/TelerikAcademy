using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter equation like : ax^2 +bx +c = 0");
        Console.Write("Enter a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c = ");
        double c = double.Parse(Console.ReadLine());
        if (a != 0)
        {
            double D = (b * b) - (4 * a * c); //Discriminant   
            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("The roots of the equation are x1 = {0:0.####} and x2 = {1:0.####}", x1, x2);
            }
            else if (D == 0)
            {
                double x = (-b) / (2 * a);
                Console.WriteLine("The equation have double root x = {0:0.####}", x);
            }
            else
            {
                Console.WriteLine("The equation does not have real roots!");
            }
        }
        else if ((a == 0) && (b == 0)) //cases with a = 0
        {
            if (c != 0)
            {
                Console.WriteLine("The equation does not have real roots!");
            }
            else
            {
                Console.WriteLine("Every x is a root of the quation");
            }
        }
        else
        {
            double x = (-c) / b;
            Console.WriteLine("The root of the quation is x = {0:0.####}", x);
        }
    }
}

