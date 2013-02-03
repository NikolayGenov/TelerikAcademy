using System;
using System.Collections.Generic;

class Dictionary
{
    static void Main()
    {
        //Create a dictionary
        Dictionary<string, string> words = new Dictionary<string, string>();
        //Add 3 words and values to it
        words.Add(".NET", "platform for applications from Microsoft");
        words.Add("CLR", "managed execution environment for .NET");
        words.Add("namespace", "hierarchical organization of classes");

        //User input
        Console.WriteLine("Enter a word from the Dictionary:");
        string word = Console.ReadLine();
        //Try to find the key in the Dictionary but if it can not be found it throws an exception
        try
        {
            Console.WriteLine("{0} - {1}", word, words[word]);
        }
        catch (KeyNotFoundException)
        {
            //Catches the exception and gives a msg to the user
            Console.WriteLine("'{0}' is not found in the Dictionary", word);
        }
    }
}