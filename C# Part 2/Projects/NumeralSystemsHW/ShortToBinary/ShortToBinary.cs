using System;

class ShortToBinary
{
    static void Main(string[] args)
    {
        //User input for short number
        Console.WriteLine("Enter short number: ");
        short number = short.Parse(Console.ReadLine());
        Console.WriteLine("The binary representation is : {0}", ShortToBin(number));
    }
    
    private static string ShortToBin(short number)
    {
        //Using bitwise mask and operating with it where we add 1 and 0 depending what if returned as true or false
        string result = null;
        for (int i = 0; i < 16; i++)
        {
            int mask = (1 << i);

            if ((number & mask) == mask)
            {
                result += "1";
            }
            else
            {
                result += "0";
            }
        }
        //reversing the result and then returning it to print it
        return Reverse(result);
    }

    public static string Reverse(string s)
    {
        //Simple reverse string method
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}