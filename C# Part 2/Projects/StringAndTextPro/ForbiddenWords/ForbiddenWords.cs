using System;

class ForbiddenWords
{
    static void Main()
    {
        //Input for and list of words
        string input = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string words = "PHP, CLR, Microsoft";
      
        //Split the list of words and then trim it from the spaces
        string[] forWords = words.Split(',');
        for (int i = 0; i < forWords.Length; i++)
        {
            forWords[i] = forWords[i].Trim(' ');
        }
        //Using for reach we replace the word with starts coresponding to its length
        foreach (string word in forWords)
        {
            string stars = new string('*',word.Length);
            input = input.Replace(word, stars);
        }
        //Print the result
        Console.WriteLine("After replacing:");
        Console.WriteLine(input);
    }
}