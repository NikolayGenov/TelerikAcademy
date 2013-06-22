using System;

class CheckThirdDigit
{
    static void Main()
    {
        Console.WriteLine("Enter a number : ");
        int n = int.Parse(Console.ReadLine());
        if ((n / 100) % 10 == 7)
        {
            Console.WriteLine("In the number {0} , the third digit is 7", n);
        }
        else
        {
            Console.WriteLine("In the number {0} , the third digit is NOT 7", n);
        }
    }
}

