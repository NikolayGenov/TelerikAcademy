using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class DeleteOnlyPrefixWord
{
    static void Main()
    {
        StringBuilder output = new StringBuilder();
        using (StreamReader reader = new StreamReader(@"../../text.txt"))
        {
            string text = reader.ReadLine();
            //Read till the end of the file
            while (text != null)
            {
                //Using regular expressions to find the word with that prefix (not only the prefix) and delete it (if it finds only the prefix it skips it)
                text = Regex.Replace(text, @"\btest\w+\b", string.Empty);
                //Append to the stringbuilder                 
                output.Append(text + " \r\n");
                text = reader.ReadLine();
            }
        }
        //Writing to another  file
        using (StreamWriter sameFileOutput = new StreamWriter(@"../../output.txt"))
        {
            sameFileOutput.WriteLine(output);
        }
        Console.WriteLine("Done!");
    }
}