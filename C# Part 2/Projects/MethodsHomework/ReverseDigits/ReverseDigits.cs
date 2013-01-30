using System;

class ReverseDigits
{
    static void Main()
    {
        //User input for an int
        Console.WriteLine("Enter a number");
        int number = int.Parse(Console.ReadLine());
        //Call the method
        PrintReversedNumber(number);
    }
  
    private static void PrintReversedNumber(int number)
    {
        //Using while loop to take the last digit of the number and print it
        //If that number is less than 10 just print the last one
        while (number > 9)
        {
            Console.Write(number % 10);
            number /= 10;
        }      
        Console.WriteLine(number % 10);
        return;
    }
}

