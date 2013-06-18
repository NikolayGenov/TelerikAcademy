using System;

class QuotationsStrings
{
    static void Main()
    {
        string oneWay = "The \"use\" of quotations causes difficulties.";
        string anotherWay = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(oneWay);
        Console.WriteLine(anotherWay);
    }
}
