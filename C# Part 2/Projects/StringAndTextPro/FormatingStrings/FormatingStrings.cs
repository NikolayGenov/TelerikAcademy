using System;

class FormatingStrings
{
    static void Main()
    {
        //User input
        Console.WriteLine("Enter a number");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine("Results:");
        Console.WriteLine("{0,15:D}", input); //Decimal
        Console.WriteLine("{0,15:X}", input); //Hexadecimal
        Console.WriteLine("{0,15:P0}", input); //Percentage 
        Console.WriteLine("{0,15:E}", input); //Scientific notation
    }
}