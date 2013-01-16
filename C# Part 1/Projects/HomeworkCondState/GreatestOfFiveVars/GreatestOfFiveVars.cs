using System;


class GreatestOfFiveVars
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int num1 = int.Parse(Console.ReadLine());
        int greatest = num1;
        Console.WriteLine("Enter second number:");
        int num2 = int.Parse(Console.ReadLine());
        if (greatest < num2)
        {
            greatest = num2;
        }
        Console.WriteLine("Enter third number:");
        int num3 = int.Parse(Console.ReadLine());
        if (greatest < num3)
        {
            greatest = num3;
        }
        Console.WriteLine("Enter forth number:");
        int num4 = int.Parse(Console.ReadLine());
        if (greatest < num4)
        {
            greatest = num4;
        }
        Console.WriteLine("Enter fifth number:");
        int num5 = int.Parse(Console.ReadLine());
        if (greatest < num5)
        {
            greatest = num5;
        }
        Console.WriteLine("The greatest number is {0}", greatest);

    }
}

