using System;

class LastDigitAsWord
{
    static void Main()
    {
        //User input
        Console.WriteLine("Enter a number");
        int number = int.Parse(Console.ReadLine());
        //Call the method and print the string that it will return
        Console.WriteLine(LastDigit(number));
    }
  
    private static string LastDigit(int number)
    {
        //If the number is negative make it possitive
        if (number < 0)
        {
            number *= -1;
        }
        //Take the last digit and then with switch return string result
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

