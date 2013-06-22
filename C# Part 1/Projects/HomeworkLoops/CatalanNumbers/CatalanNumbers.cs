using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());
        BigInteger catNums;
        BigInteger sum1 = 1, sumNfact = 1;
        for (int i = n + 2; i <= 2 * n; i++)
        {
            sum1 *= i;
        }
        for (int i = 1; i <= n; i++)
        {
            sumNfact *= i;
        }
        catNums = sum1 / sumNfact;
        Console.WriteLine("Catalan number: {0}", catNums);
    }
}

