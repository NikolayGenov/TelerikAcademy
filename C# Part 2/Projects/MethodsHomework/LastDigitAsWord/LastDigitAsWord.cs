using System;

class LastDigitAsWord
{
    static void Main()
    {
        Console.WriteLine("Enter a number");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(LastDigit(number));
    }
  
    private static string LastDigit(int number)
    {
        if (number < 0)
        {
            number *= -1;
        }
        number %= 10;
        switch (number)
        {
            case 1:
                return "one";
            case 2:
                return "two";
            case 3:
                return "three";
            case 4:
                return "four";                
            case 5:
                return "five";                
            case 6:
                return "six";
            case 7:
                return "seven";                
            case 8:
                return "eight";                
            case 9:
                return "nine";
            default:
                return "zero";
        }
    }
}

