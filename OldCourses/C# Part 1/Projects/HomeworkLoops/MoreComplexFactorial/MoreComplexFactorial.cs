using System;

class MoreComplexFactorial
{
    static void Main()
    {
        Console.WriteLine("Enter (where N<K) N:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K:");
        int k = int.Parse(Console.ReadLine());     
        long sum = 1,sum1 = 1;
        if ((n < k) && (n > 1))
        {
            for (int i = (k - n + 1); i <= k; i++)
            {
                sum *= i;
            }
            for (int i = 1; i <= n; i++)
            {
                sum1 *= i;
            }
            sum = sum * sum1;
            Console.WriteLine("The sum of N!*K!/(K-N)! is: {0}", sum);
        }
        else
        {
            Console.WriteLine("ERROR");
        }
    }
}