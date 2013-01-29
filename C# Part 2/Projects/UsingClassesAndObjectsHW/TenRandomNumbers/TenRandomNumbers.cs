using System;

class TenRandomNumbers
{
    static void Main()
    {
        //Using the random class
        Random rand = new Random();
        //Amount of random numbers we want
        int times = 10;
        Console.WriteLine("Random Numbers [100-200] : ");
        //Loop the amount of times we want; Using next and the range we set that we can only get random between 100 and 200
        for (int i = 0; i < times; i++)
        {
            Console.WriteLine(rand.Next(100,200));
        }
    }
}