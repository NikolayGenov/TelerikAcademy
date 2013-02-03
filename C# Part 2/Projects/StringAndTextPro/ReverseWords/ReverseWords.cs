using System;
using System.Text;

class ReverseWords
{
    static void Main(string[] args)
    {
        //Using stringbuilder for the result
        StringBuilder output = new StringBuilder(); 
        char[] sep = { ' ' };
        //Input and then split the and save to a array of strings with no empty entries
        string input = "C# is not C++, not PHP and not Delphi!";
        string[] words = input.Split(sep, StringSplitOptions.RemoveEmptyEntries);
        //Make an array where we would save the punctuation
        string[] punc = new string[words.Length];
        //We loop to the end and where we find one of those in the words we add it to the array and then trim it from the word
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Contains(","))
            {
                punc[i] = ",";
                words[i] = words[i].Trim(',');
            }
            if (words[i].Contains("."))
            {
                punc[i] = ".";
                words[i] = words[i].Trim('.');
            }
            if (words[i].Contains("!"))
            {
                punc[i] = "!";
                words[i] = words[i].Trim('!');
            }
        }
        //Looping backwards and append to the output where we add punctuation if its found in the array and spaces
        for (int i = words.Length - 1; i >= 0; i--)
        {
            output.Append(words[i]);
            output.Append(punc[words.Length - 1 - i]);
            if (i != 0)
            {
                output.Append(" ");
            }
        }
        //Print out the result
        Console.WriteLine("Input:\n{0}", input);
        Console.WriteLine("Output:\n{0}", output);
    }
}