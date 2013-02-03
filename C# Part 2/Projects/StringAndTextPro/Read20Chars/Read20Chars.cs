using System;

class Read20Chars
{
    static void Main()
    {
        //Enter a string until we enter a string with valid length less or equal to 20
        string input = null;
        int len = 0;
        do
        {
            Console.WriteLine("Enter a string with length 20 or less");
            input = Console.ReadLine();
            len = input.Length;
        }
        while (len > 20);
        //Add a star starting from the length of the string to 20
        for (int i = len; i < 20; i++)
        {
            input = input.Insert(len, "*");
        }
        //Output
        Console.WriteLine("Result:");
        Console.WriteLine(input);
    }
}