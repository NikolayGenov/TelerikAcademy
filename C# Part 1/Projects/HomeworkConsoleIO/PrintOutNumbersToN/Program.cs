using System;

class PrintOutNumbersToN
{
    static void Main()
    {
        Console.Write("Enter n = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("The numbers from [1,{0}] are",n);
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(i+1);
        }
    }
}

