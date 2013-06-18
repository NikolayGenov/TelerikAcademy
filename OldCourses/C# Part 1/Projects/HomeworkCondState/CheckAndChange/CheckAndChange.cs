using System;

class CheckAndChange
{
    static void Main()
    {
        Console.WriteLine("Enter first value:");
        int firstVal = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second value:");
        int secondVal = int.Parse(Console.ReadLine());
        if (firstVal > secondVal)
        {   //Excharging values
            int temp = secondVal;
            secondVal = firstVal;
            firstVal = temp;
            Console.WriteLine("First value is greater than the second -> Change");
            Console.WriteLine("The values are\nFirst value = {0}\nSecond value = {1}", firstVal, secondVal);
        }
        else
        {   //Print only
            Console.WriteLine("First value is less than the second");
            Console.WriteLine("The values are\nFirst value = {0}\nSecond value = {1}", firstVal, secondVal);
        }
    }
}

