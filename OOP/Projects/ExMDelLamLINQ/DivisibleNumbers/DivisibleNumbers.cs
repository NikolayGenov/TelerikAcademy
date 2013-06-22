using System;
using System.Linq;

class DivisibleNumbers
{
    static void Main(string[] args)
    {
        //Some numbers
        int[] intArray = { 1995, 791, 6, 21, 10, 432, 70, 231, 42, 43, 2043, 4221, 214 };

        Console.WriteLine("Lambda: ");
        //using lambra expr and Where we put all those numbers in a list and then print it
        var listNumbersLambda = intArray.Where(number => (number % 7 == 0) && (number % 3 == 0));
        foreach (var number in listNumbersLambda)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine();
            
        //Doing pretty much the same thing but with LINQ
        var listNumbers =
                         from number in intArray
                         where ((number % 7 == 0) && (number % 3 == 0))
                         select number;
        Console.WriteLine("LINQ: ");
        foreach (var number in listNumbers)
        {
            Console.WriteLine(number);
        }
    }
}