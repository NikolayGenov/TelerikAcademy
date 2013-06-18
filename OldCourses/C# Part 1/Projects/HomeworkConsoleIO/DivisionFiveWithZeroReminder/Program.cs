using System;

class DivisionFiveWithZeroReminder
{
    static void Main()
    {
        Console.WriteLine("Enter interval [a,b]");
        Console.Write("a = ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int secondNum = int.Parse(Console.ReadLine());
        int intv1 = firstNum / 5;
        int intv2 = secondNum / 5;
        int result = intv2 - intv1;
        if (firstNum % 5 == 0)
        {
            result++;
        }
        Console.WriteLine("There are {0} numbers divided by 5 with reminder 0 in [{1},{2}]",result,firstNum,secondNum);

    }

}

