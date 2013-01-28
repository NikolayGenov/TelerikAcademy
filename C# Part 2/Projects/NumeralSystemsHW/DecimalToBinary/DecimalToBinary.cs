using System;
using System.Collections.Generic;

class DecimalToBinary
{
    static void Main()
    {
        List<int> arr = new List<int>();
        Console.WriteLine("Enter decimal number");
        int number = int.Parse(Console.ReadLine());
        //Because we can do that but we will get the numbers in the reversed order we save them to list first
        while (number != 0)
        {
            arr.Add(number % 2);
            number /= 2;
        }
        Console.WriteLine("Binary code of that number is :");
        //Then we print the in the reversed order
        for (int i = arr.Count - 1; i >= 0; i--)
        {
            Console.Write(arr[i]);
        }
        Console.WriteLine();
    }
}