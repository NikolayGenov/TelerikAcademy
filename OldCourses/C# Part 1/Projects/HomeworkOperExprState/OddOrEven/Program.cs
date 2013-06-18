using System;

class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Enter a number \nn =");
        int n = int.Parse(Console.ReadLine());
        if (n % 2 == 0)
        {
            Console.WriteLine("The number n={0} is even",n);
        }
        else
        {
            Console.WriteLine("The number n={0} is odd",n);
        }
    }
}

