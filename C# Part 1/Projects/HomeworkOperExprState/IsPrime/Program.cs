using System;

class IsPrime
{
    static void Main()
    {
        bool isPrime = true;
        int number;
        do
        {
            Console.WriteLine("Enter a number \nn= ");
            number = int.Parse(Console.ReadLine());
        } while ((number > 100) || (number <= 0));
        isPrime = (number % 2 != 0) && (number % 3 != 0) && (number % 5 != 0) &&
    (number % 7 != 0) || ((number == 2) || (number == 3) || (number == 5) || (number == 7));
        if (isPrime)
        {
            Console.WriteLine("The number is Prime");
        }
        else
        {
            Console.WriteLine("The number is NOT prime");
        }
    }
}

