using System;

class UnicodeChars
{
    static void Main()
    {
        //User input
        Console.WriteLine("Enter a string");
        string input = Console.ReadLine();
        Console.WriteLine("Result in Unicode:");
        //Loop for each char to the end of the input string and take the integer of the char and using formating X4 we parse it to hexadecimal 
        //Also we use escaping for the slash \ with \\ and u 
        for (int i = 0; i < input.Length; i++)
        {
            Console.Write("\\u{0:X4}", (int)input[i]);            
        }
        Console.WriteLine();
    }
}
