using System;
using System.Collections.Generic;
using System.Text;

class Task2
{
    static void Main()
    {
        List<short> input = GetList();
        int jumps = CalcJumps(input);
        Console.WriteLine(jumps);
    }

    private static short CalcJumps(List<short> input)
    {
        short count = 1;
        short maxCount = 0;
        short step = 1;
        short i = 0;
        while (i != input.Count)
        {
            while (step != input.Count)
            {
                short prevStep = i;
                short nextStep = (short)((i + step) % input.Count);
             
                while (true)
                {
                    if (input[prevStep] < input[nextStep])
                    {
                        count++;                        
                        prevStep = nextStep;
                    }
                    else
                    {
                        if (count > maxCount)
                            maxCount = count;                       
                        count = 1;
                        break;
                    }
                    nextStep = (short)((nextStep + step) % input.Count);
                    //nextStep += step;
                    //nextStep %= input.Count;
                }
                step++;
            }
            i++;
            step = 1;
        }
        
        return maxCount;
    }

    private static List<short> GetList()
    {
        List<short> numbers = new List<short>();
        char[] sep = new char[','];
        string input = Console.ReadLine();
        string[] beforeParse = input.Split(',');
        foreach (string item in beforeParse)
        {
            numbers.Add(short.Parse(item));
        }
        return numbers;
    }
}