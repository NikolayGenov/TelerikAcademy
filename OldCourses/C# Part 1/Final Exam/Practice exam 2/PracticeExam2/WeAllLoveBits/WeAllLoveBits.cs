using System;

class WeAllLoveBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            int newNumber = PerformAlgorithm(number);
            Console.WriteLine(newNumber);
        }
    }

    private static int PerformAlgorithm(int number)
    {
        int p = number;
       int pTilda = InvertNumber(number);      
        int pReversed = Reverse(number);
        int pNew = (p ^ pTilda) & pReversed;  
        return pNew;
    }

    private static int Reverse(int number)
    {
        int reserved = 0;
        int length = Convert.ToString(number, 2).Length;
        for (int i = 0; i < length; ++i)
        {
            reserved <<= 1;
            reserved |= (number & 1);
            number >>= 1;
        }
        return reserved;
    }
    private static int InvertNumber(int number)
    {
        int mask = 1;
        int length = Convert.ToString(number, 2).Length;
        for (int i = 0; i < length; i++)
        {
            number = number ^ mask;
            mask <<= 1;
        }
        return number;
    }
}