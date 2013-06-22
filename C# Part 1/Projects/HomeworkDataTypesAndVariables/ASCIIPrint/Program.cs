using System;
using System.Text;

class ASCIIPrint
{
    static void Main()
    {   //Printing the first 256 of the ASCII table
        for (int i = 0; i < 256; i++)
        {
            char asciiPos = (char)i;
            Console.Write(asciiPos + " ");
        }
    }
}

