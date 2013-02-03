using System;
using System.Collections.Generic;

class ExtractSentences
{
    static void Main(string[] args)
    {
        //Parameters we use to separate the string
        char[] sep = { '.', ',', ' ' };
        //Inout and a key word that are given
        string input = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day.We will move out of it in 5 days.";
        string keyWord = "in";
        //First we sptit the sentences by the '.'
        string[] sentences = input.Split('.');
        //Using list to save the output
        List<string> output = new List<string>();
        //Looping for reach sentence in all of them
        foreach (string sentence in sentences)
        {
            //Spliting the sentence to words and set a flag to false
            string[] words = sentence.Split(sep);
            bool isInSentence = false;
            foreach (string word in words)
            {
                //Looping for each word and if we find a match we set the flag to true
                if (word == keyWord)
                    isInSentence = true;
            }
            //If the flag is true we add the sentence to the output list
            if (isInSentence)
            {
                output.Add(sentence + ".");
            }
        }
        //Print the output list
        Console.WriteLine("The sentences that contain '{0}' are :", keyWord);
        foreach (string haveKey in output)
        {
            Console.WriteLine(haveKey);
        }
    }
}