using System;

class PrintNumbersToN
{
    static void Main()
    {
        Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("The numbers from 1 to N={0} are: ", n);
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}


