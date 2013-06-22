using System;


class PrintGreaterOne
{
    static void Main()
    {
        Console.Write("Enter a number a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter a number b = ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("The greater one is : " + ((a > b) ? ("a = " + a) : ("b = " + b)));
    }
}

