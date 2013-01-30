using System;

class GetMaxMet
{
    static void Main()
    {
        //User input for A and B
        Console.WriteLine("Enter number A = ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number B = ");
        int b = int.Parse(Console.ReadLine());
        //Call the method and save the result that it will return to A
        a = GetMax(a, b);
        //User input for C
        Console.WriteLine("Enter number C = ");
        int c = int.Parse(Console.ReadLine());
        //Call the method again and save the result again at A
        a = GetMax(a, c);
        //Print the result
        Console.WriteLine("Max number = {0}",a);
    }
  
    private static int GetMax(int a, int b)
    {
        //Simple method using if and else
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

