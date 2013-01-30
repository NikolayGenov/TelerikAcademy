using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class CountWords
{
    static void Main()
    {
        try
        {
            //Reading the file
            using (StreamReader reader = new StreamReader(@"../../test.txt"))
            {
                //Using a list where we would store the words
                List<string> listWords = new List<string>();
                //Call Method
                AddWordsToList(listWords);
                int[] counter = FindTimesInText(listWords, reader);
                //We "cast" the list to array and then sort the array and the counter at the same time
                string[] wordsArray = listWords.ToArray();
                Array.Sort(counter, wordsArray);
                //Reverse each one of them to be in the desired order
                Array.Reverse(counter);
                Array.Reverse(wordsArray);        
                //Write the result in a file using formating
                WriteToFile(wordsArray, counter);
                Console.WriteLine("Done!");
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("That file has not been found");
        }
        catch (IOException ex)
        {
            Console.WriteLine("Input/Output Exception");
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine("You don't have permisions to access that.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("General Exception");
        }
        
    }
  
    private static void WriteToFile(string[] wordsArray, int[] counter)
    {
        //Write the result in a file using formating
        using (StreamWriter outputFile = new StreamWriter(@"../../result.txt"))
        {
            for (int i = 0; i < wordsArray.Length; i++)
            {
                outputFile.WriteLine(string.Format("{0} - {1} times", wordsArray[i], counter[i]));
            }
        }
    }
  
    private static void AddWordsToList(List<string> listWords)
    {
        //First reading the words and add them to the list and remove the last null emtry
        using (StreamReader words = new StreamReader(@"../../words.txt"))
        {
            string word = words.ReadLine();

            while (word != null)
            {
                word = words.ReadLine();
                listWords.Add(word);
            }
            listWords.Remove(null);
            //Sort the array in inc order
            listWords.Sort();
        }
    }
  
    private static int[] FindTimesInText(List<string> listWords, StreamReader reader)
    {
        //Define a new array to store to count of each word is found in the text
        int[] counter = new int[listWords.Count];

        string text = reader.ReadLine();
        //Read lines till the end of the file
        while (text != null)
        {
            //For all the words in the list we loop
            for (int i = 0; i < listWords.Count; i++)
            {
                //We make a patern and using isMatch we take a boolean result if we have found this word in the line
                //If its true we add one to the corresponding index of the word
                string word = listWords[i];                
                bool match = false;
                string patern = string.Format(@"\b{0}\b", word);
                //Returnes bool
                match = Regex.IsMatch(text, patern);
                if (match)
                {
                    counter[i]++;
                }
            }
            //Go to the next line
            text = reader.ReadLine();
        }
        return counter;
    }
}