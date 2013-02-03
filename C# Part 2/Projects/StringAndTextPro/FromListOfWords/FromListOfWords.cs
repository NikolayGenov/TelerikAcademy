using System;

class FromListOfWords
{
    static void Main()
    {
        //Input the words
        string input = "table chair computer telephone glass knife books monitor";
        string[] words = input.Split(' '); //Split them by a space
        Array.Sort(words); //Sort them in alphabetical order  
        //Print them 
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}