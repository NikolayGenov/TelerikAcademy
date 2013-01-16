using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        BigInteger first = int.Parse(Console.ReadLine());
        BigInteger second = int.Parse(Console.ReadLine());
        BigInteger third = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        BigInteger result = 0;

        switch (n)
        {
            case 1:
                Console.WriteLine(first);
                break;
            case 2:
                Console.WriteLine(second);
                break;
            case 3:
                Console.WriteLine(third);
                break;
            default:
                {
                    for (int i = 3; i < n; i++)
                    {
                        result = first + second + third;
                        first = second;
                        second = third;
                        third = result;
                    }

                    Console.WriteLine(result);
                }
                break;
        }
    }
}