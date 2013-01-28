using System;
using System.Collections.Generic;

class BinaryToDecimal
{
    static void Main()
    {     
        List<int> arr = new List<int>();
        Console.WriteLine("Enter binary number");
        long binNumber = long.Parse(Console.ReadLine());
        while (binNumber != 0)
        {
            long temp = binNumber % 10;
            if (temp != 1 && temp != 0)
            {
                Console.WriteLine("ERROR - NOT a binary number");
                break;
            }
            arr.Add((int)temp);
            binNumber /= 10;

        }
        long number = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            number += arr[i] * ((1 << i));
        }
        Console.WriteLine("The decimal number is {0}",number);
    }
}

