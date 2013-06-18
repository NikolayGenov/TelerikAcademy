using System;

class FindBiggestOfThree
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int firstNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int secondNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number:");
        int thirdNum = int.Parse(Console.ReadLine());
        int biggestNum;
        if (firstNum > secondNum)
        {
            biggestNum = firstNum; 
            if (biggestNum < thirdNum)
            { 
                biggestNum = thirdNum; 
            }
        }
        else
        {
            biggestNum = secondNum;
            if (biggestNum < thirdNum) 
            {
                biggestNum = thirdNum;
            } 
        }
        Console.WriteLine("The biggest  number is {0}", biggestNum);
    }
}

