using System;

class HelloUser
{
    static void Main()
    {
        Console.WriteLine("Enter your name");
        PrintName(Console.ReadLine());
    }

    private static void PrintName(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }
}

