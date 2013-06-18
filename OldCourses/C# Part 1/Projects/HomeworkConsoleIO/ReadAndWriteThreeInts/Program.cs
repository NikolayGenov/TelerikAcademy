using System;

class ReadAndWriteThreeInts
{
    static void Main()
    {
        Console.WriteLine("Enter 3 numbers: ");
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());
        int sum = number1 + number2 + number3 ;
        Console.WriteLine("Number1 = {0}\nNumber2 = {1}\nNumber3 = {2}",number1,number2,number3);
        Console.WriteLine("Their sum is : {0} ",sum);
    }
}

