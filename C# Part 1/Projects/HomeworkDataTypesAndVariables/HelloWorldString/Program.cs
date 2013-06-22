using System;

class HelloWorldString
{
    static void Main()
    {
        string helloString = "Hello";
        string worldString = "World";
        object helloWorldObj = helloString + " " + worldString;
        string helloWorldString = (string)helloWorldObj;
        Console.WriteLine(helloWorldObj);
        Console.WriteLine(helloWorldString);
    }
}
