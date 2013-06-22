using System;
using System.Numerics;

class First100Fibonacci
{
    static void fMain()
    {
        BigInteger fibNum1 = 0, fibNum2 = 1;
        BigInteger n = 0;
       
        for (int i = 0; i < 100; i++)
        {// da q mucha v vku6ti
            Console.WriteLine("The {0} Fib is : {1}", (i + 1), fibNum1);
            n = fibNum1 + fibNum2;
            fibNum1 = fibNum2;
            fibNum2 = n;
        }
    }
}
