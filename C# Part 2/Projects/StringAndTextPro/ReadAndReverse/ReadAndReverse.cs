using System;

class ReadAndReverse
{
    static void Main()
    {
        //User input
        Console.WriteLine("Enter a string");
        string input = Console.ReadLine();
        //Print the reversed string
        Console.WriteLine(Reverse(input));
    }

    public static string Reverse(string s)
    {
        //Simple reverse string method
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}