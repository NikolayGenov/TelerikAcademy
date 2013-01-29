using System;

class ReadSomeNumbers
{
    static void Main()
    {
        //Giving starting and enduing index, number of times that we enter a number
        int start = 1,end = 100;
        int times = 10;
        int number = 0; // a place were we could save or do stuff with the number
        for (int i = 0; i < times; i++)
        {
            //Giving user instructions about the number and what range should it be in
            Console.WriteLine("Enter number a{2} greater than {0} and less than {1}", start, end, i + 1);
            number = ReadNumber(start, end); //Calling the method and the returned value becomes the new lower boundary of the range
            start = number;
        }
    }
  
    private static int ReadNumber(int start, int end)
    {
        //Using try catch 
        try
        {
            //We set the range and if the number is not in that range we throw exception with some parameters
            int number = int.Parse(Console.ReadLine());
            if ((number >= end) || (number <= start))
            {
                throw new ArgumentOutOfRangeException("Not in range number");
            }
            //If there are no problems we return the number
            return number;
        }
        catch (FormatException)
        {
            //Non a number input or none input
            throw new FormatException("Not a valid number");
        }
    }
}