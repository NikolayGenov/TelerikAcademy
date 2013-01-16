using System;


class SortThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int firstNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int secondNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number:");
        int thirdNum = int.Parse(Console.ReadLine());
        int min = firstNum, mid = secondNum, max = thirdNum;
        if ((firstNum >= secondNum) && (firstNum >= thirdNum))
        {
            max = firstNum;
            if (secondNum > thirdNum)
            {
                mid = secondNum;
                min = thirdNum;
            }
            else
            {
                min = secondNum;
                mid = thirdNum;
            }
        }
        else
        {
            if ((secondNum >= firstNum) && (secondNum >= thirdNum))
            {
                max = secondNum;
                if (firstNum > thirdNum)
                {
                    mid = firstNum;
                    min = thirdNum;
                }
                else
                {
                    min = firstNum;
                    mid = thirdNum;
                }
            }
            else
            {
                if ((thirdNum >= secondNum) && (thirdNum >= firstNum))
                {
                    max = thirdNum;
                    if (secondNum > firstNum)
                    {
                        mid = secondNum;
                        min = firstNum;
                    }
                    else
                    {
                        min = secondNum;
                        mid = firstNum;
                    }
                }
            }


        }

        Console.WriteLine("The numbers are {0} {1} {2}", max, mid, min);
    }
}

