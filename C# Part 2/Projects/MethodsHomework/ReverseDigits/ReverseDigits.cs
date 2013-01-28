using System;

class ReverseDigits
{
    static void Main()
    {
        Console.WriteLine("Enter a number");
        int number = int.Parse(Console.ReadLine());
        PrintReversedNumber(number);
    }
  
    private static void PrintReversedNumber(int number)
    {
        while (number > 9)
        {
            Console.Write(number % 10);
            number /= 10;
        }      
        Console.WriteLine(number % 10);
        return;
    }
}

