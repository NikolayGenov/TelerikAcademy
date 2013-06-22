using System;

class BooleanCheckForBitAtPosition
{
    static void Main()
    {
        Console.WriteLine("Enter a number V:");
        int v = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a position P:");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        bool isOne = ((v & mask) == mask);
        Console.WriteLine("For the number {0} it is {1} that it have '1' bit at position {2}", v, isOne, p);
    }
}

