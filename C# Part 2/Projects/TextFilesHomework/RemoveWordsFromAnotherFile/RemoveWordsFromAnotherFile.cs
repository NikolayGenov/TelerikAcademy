using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class RemoveWordsFromAnotherFile
{
    static void Main()
    {
        //Try to catch some exceptions if there are any
        try
        {
            StringBuilder output = new StringBuilder();
            //Reading the file with the text and then the file with the words
            using (StreamReader reader = new StreamReader(@"../../text.txt"))
            {
                using (StreamReader words = new StreamReader(@"../../words.txt"))
                {
                    string text = reader.ReadLine();
                    //Read lines till the end of the file
                    while (text != null)
                    {
                        //we read words till the end of the words file
                        text = MatchForWords(words, text);
                        //Append to the stringbuilder   
                        output.Append(text + " \r\n");
                        text = reader.ReadLine();
                    }
                }
            }
            //Writing to the another file
            using (StreamWriter sameFileOutput = new StreamWriter(@"../../output.txt"))
            {
                sameFileOutput.WriteLine(output);
            }
            Console.WriteLine("Done!");
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
  
    private static string MatchForWords(StreamReader words, string text)
    {
        //we read words till the end of the words file
        string word = words.ReadLine();
        while (word != null)
        {
            //Foe each word we create a patern and check with it using regex
            string patern = string.Format(@"\b{0}\b", word);
            //Using regular expressions to find the patern we are looking for
            text = Regex.Replace(text, patern, string.Empty);   
            word = words.ReadLine();
        }
        return text;
    }
}