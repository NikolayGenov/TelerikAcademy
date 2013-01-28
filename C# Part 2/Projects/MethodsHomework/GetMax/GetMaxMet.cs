using System;

class GetMaxMet
{
    static void Main()
    {
        Console.WriteLine("Enter number A = ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number B = ");
        int b = int.Parse(Console.ReadLine());
        a = GetMax(a, b);
        Console.WriteLine("Enter number C = ");
        int c = int.Parse(Console.ReadLine());
        a = GetMax(a, c);
        Console.WriteLine("Max number = {0}",a);
    }
  
    private static int GetMax(int a, int b)
    {
        if (a>b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}

