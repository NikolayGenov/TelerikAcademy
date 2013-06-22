using System;

class SumOfNAndX
{
    static void Main()
    {
        Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter X:");
        int x = int.Parse(Console.ReadLine());
        double sum = 1, sumXPowerN = 1, nFact = 1;
        for (int i = 0; i < n; i++)
        {
            //Finding X to the Nth
            sumXPowerN *= x;
        }
        Console.WriteLine("X to the Nth is : {0}", sumXPowerN);
        for (int i = 1; i <= n; i++)
        {
            //Finding N Fact
            nFact *= i;
        }
        Console.WriteLine("N factorial is {0}", nFact);
        for (int i = n; i > 0; i--)
        {
            //Adding to the sum
            sum += nFact / sumXPowerN;
            nFact /= i;
            sumXPowerN /= x;
        }
        Console.WriteLine("The sum of N!/X^n all those is :{0}", sum);
    }
}