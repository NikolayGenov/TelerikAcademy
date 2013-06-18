using System;


class DifferentInputType
{
    static void Main()
    {
        string var = Console.ReadLine();
        int varInt;
        double varDouble;
        bool isInt = int.TryParse(var, out varInt);
        bool isDouble = double.TryParse(var, out varDouble);
        byte whatCase = 0; //Using for the case statement
        if (isInt) //If we enter int
        {
            whatCase = 1;
        }
        if (isDouble && (!isInt)) //If we enter double
        {
            whatCase = 2;
        }
        switch (whatCase) //Use the values 1 2 or def = 0
        {
            case 1: Console.WriteLine("The new int is {0}", varInt + 1); break;
            case 2: Console.WriteLine("The new double is {0}", varDouble + 1); break;
            default: Console.WriteLine("The new string is: '{0}'", var + "*"); break;
        }

    }
}

