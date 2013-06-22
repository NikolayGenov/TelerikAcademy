using System;

class CompareTwoFloatingPointNumbers
{
    static void Main()
    {
        double a, b;
        double precision = 0.000001;
        Console.WriteLine("Enter two numbers");
        Console.WriteLine("a = ");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("b = ");
        b = double.Parse(Console.ReadLine());

        if ((Math.Abs(a-b)) < precision)
        {
            Console.WriteLine("The difference between {0} and {1} is less than 0.000001 ", a, b);
        }
        else
        {
            Console.WriteLine("The difference between {0} and {1} is greater than 0.000001 ", a, b);
        }


    }
}

