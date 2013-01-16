using System;

class NullValues
{
    static void Main()
    {
        int? intValue = null;
        double? doubleValue = null;
        Console.WriteLine(intValue); //prints out the values
        Console.WriteLine(doubleValue);
        //Adding some values;
        intValue = 5;
        doubleValue = 5.5;
        Console.WriteLine(intValue);
        Console.WriteLine(doubleValue);
    }
}

