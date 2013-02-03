using System;

class PrintDiffWords
{
    static void Main(string[] args)
    {
        char[] sep = { ' ' };
        //User input
        Console.WriteLine("Enter a string");
        string input = Console.ReadLine();
        //Spliting to array of strings
        string[] words = input.Split(sep, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(words); //Sort it 
        //For different cases
        switch (words.Length)
        {
            case 0:
                Console.WriteLine("Empty string");
                break;
            case 1:
                Console.WriteLine("{0}: {1} time", words[0], 1);
                break;
            default:                
                CountAndPrintLetters(words);                
                break;
        }
    }
  
    private static void CountAndPrintLetters(string[] letters)
    {
        int counter = 1;
        //For each word we count how many times it is found and then print it
        for (int i = 0; i < letters.Length - 1; i++)
        {
            if (letters[i] == letters[i + 1])
                counter++;
            else
            {
                Console.WriteLine("{0}: {1} times", letters[i], counter);
                counter = 1;
            }
            //For the last one
            if (i == letters.Length - 2)
            {
                Console.WriteLine("{0}: {1} times", letters[i + 1], counter);
            }
        }
    }
}