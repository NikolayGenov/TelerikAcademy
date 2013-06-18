using System;

class ExtractAValue
{
    static void Main()
    {
        Console.WriteLine("Enter a number i:");
        uint i = uint.Parse(Console.ReadLine());
        Console.WriteLine("Enter a bit number b:");
        int b = int.Parse(Console.ReadLine());
        int mask = 1 << b;
        uint value = (uint)(i & mask) >> b;
        Console.WriteLine("For the number {0} it is {1} at position of the {2} bit", i, value, b);
    }
}
