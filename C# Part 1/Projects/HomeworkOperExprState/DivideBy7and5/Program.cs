using System;

class DivideBy7and5
{
    static void Main()
    {
        Console.WriteLine("Enter a number \nn =");
        int n = int.Parse(Console.ReadLine());
        if ((n % 7 == 0) && (n % 5 == 0))
        {
            Console.WriteLine("The number {0} can be divided 7 and 5 without a remainder", n);
        }
        else
        {
            Console.WriteLine("The number {0} can NOT be divided 7 and 5 without a remainder", n);
        }
    }
}

