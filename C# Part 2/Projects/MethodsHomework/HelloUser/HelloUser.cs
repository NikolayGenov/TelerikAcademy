using System;

class HelloUser
{
    static void Main()
    {
        //User input for a name
        Console.WriteLine("Enter your name");
        //Call method passing a parameter we enter a string using Console Readline
        PrintName(Console.ReadLine());
    }

    private static void PrintName(string name)
    {
        //Print the name with formating
        Console.WriteLine("Hello, {0}!", name);
    }
}

