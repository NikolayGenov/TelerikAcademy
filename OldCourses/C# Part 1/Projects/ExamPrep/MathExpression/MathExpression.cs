using System;
using System.Globalization;
using System.Threading;

class MathExpression
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
        decimal N, M, P; 
        N = decimal.Parse(Console.ReadLine());
        M = decimal.Parse(Console.ReadLine());
        P = decimal.Parse(Console.ReadLine());
        int modValue = ((int)M) % 180; 
        decimal nominator = (N * N) + (1 / (M * P)) + 1337m;
        decimal denominator = N - (128.523123123m * P);
        double plusSmth = Math.Sin(modValue);
        decimal result = (nominator / denominator) + (decimal)plusSmth;
        Console.WriteLine("{0:0.000000}", result);
    }
}