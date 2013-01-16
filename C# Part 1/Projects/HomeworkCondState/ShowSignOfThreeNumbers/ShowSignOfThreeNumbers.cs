using System;

class ShowSignOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first value:");
        int firstVal = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second value:");
        int secondVal = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third value:");
        int thirdVal = int.Parse(Console.ReadLine());

        if (firstVal == 0 || secondVal == 0 || thirdVal == 0)
        {
            Console.WriteLine("The product of those 3 numbers is: 0");
        }
        else
        {
            if (((firstVal < 0) && ((secondVal < 0) && (thirdVal < 0) || ((secondVal > 0) && (thirdVal > 0)))) ||
            (firstVal > 0) && (((secondVal < 0) && (thirdVal > 0)) || ((secondVal > 0) && (thirdVal < 0))))
            {
                Console.WriteLine("The product of those 3 numbers is: -");
            }
            else
            {
                Console.WriteLine("The product of those 3 numbers is: +");
            }
        }
    }
}
