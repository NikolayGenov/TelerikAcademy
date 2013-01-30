using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceWords
{
    static void Main()
    {
        //Reading the text from the file
        using (StreamReader text = new StreamReader(@"../../text.txt"))
        {
            //Writing  in another file
            using (StreamWriter output = new StreamWriter(@"../../outputOnlyWholeWords.txt"))
            {
                string line = text.ReadLine();
                //Reading until the end of the file and for each line d
                //If we find a word using regular expressions (Regex) we search for a patern exactly like the one we gave and its only a word with 2 spaces around it
                while (line != null)
                {
                    output.WriteLine(Regex.Replace(line, @"\bstart\b", "finish"));
                    line = text.ReadLine();
                }
            }
            Console.WriteLine("Done!");
        }
    }
}