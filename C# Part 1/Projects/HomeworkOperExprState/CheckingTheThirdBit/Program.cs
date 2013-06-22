using System;

class CheckingTheThirdBit
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        ushort x = 3;
        bool result = (n & (1<<x)) != 0;
        if (result)
        {
            Console.WriteLine("The third bit is : 1");
        }
        else
        {
            Console.WriteLine("The third bit is : 0");
        }
    }
}

