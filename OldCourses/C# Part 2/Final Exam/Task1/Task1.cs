using System;
using System.Collections.Generic;
using System.Numerics;


class Task1
{
    static void Main()
    {
        List<int> input = ReadInput();
        BigInteger number = ConvertNumbers(input);
        Console.WriteLine(number);
    }

    private static BigInteger ConvertNumbers(List<int> input)
    {
        BigInteger sum = 0;
        for (int i = input.Count - 1,j =0; i >= 0; i--,j++)
        {
            BigInteger power = (BigInteger)Math.Pow(168, j);
            sum += input[i]*power;
            
        }
        return sum;
    }
  
    private static List<int> ReadInput()
    {
        bool bigNumber = false;
        List<int> output = new List<int>();    
        int sum = 0;
        while (true)
        {
            int digitInt = Console.Read();
            if (digitInt < (int)('A'))
            {
                break;
            }
            char digit = (char)digitInt;
            if ((digit <= 'Z') && (digit >= 'A'))
            {
                sum += (digit - 'A');
                bigNumber = false;
            }
            if ((digit <= 'f') && (digit >= 'a'))
            {
                sum += (digit - 'a' + 1) * 26;
                bigNumber = true;
            }
            if (bigNumber)
            {
                continue;
            }
            else
            {
                output.Add(sum);
                sum = 0;
            }
        }
        return output;
    }
}