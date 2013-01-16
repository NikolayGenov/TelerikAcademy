using System;

class SwapValues
{
    static void Main()
    {
        int firstVar = 5;
        int secondVar = 10;
        int temp;
        Console.WriteLine("First var : {0}", firstVar);
        Console.WriteLine("Second var : {0}", secondVar);
        temp = firstVar;
        firstVar = secondVar;
        secondVar = temp;
        Console.WriteLine("Exchange");
        Console.WriteLine("First var : {0}",firstVar);
        Console.WriteLine("Second var : {0}", secondVar);
    }
}
