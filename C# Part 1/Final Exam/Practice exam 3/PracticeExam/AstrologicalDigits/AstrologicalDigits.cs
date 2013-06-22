using System;

class AstrologicalDigits
{
    static void Main()
    {
        string inputString = Console.ReadLine();
        int number = 0;
        for (int i = 0; i < inputString.Length; i++)
        {
            int isDigit = inputString[i] - (int)'0';

            if (isDigit >=0 && isDigit<=9)
            {
                number += isDigit;
            }
        }

        
          
        int result = AstroCalDigts(number);
        Console.WriteLine(result);
    }

    private static int AstroCalDigts(int n)
    {
        int sum = 0;
        do
        {
            sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            n = Math.Abs(sum);

        }
        while (n > 9);
        return n;
        
    }
}