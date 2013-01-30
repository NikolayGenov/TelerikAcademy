using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class ExtractFromXML
{
    static void Main()
    {
        //Use stringBuilder to save output
        StringBuilder output = new StringBuilder();
        using (StreamReader reader = new StreamReader(@"../../text.txt"))
        {
            string text = reader.ReadLine();
            //Read till the end of the file
            while (text != null)
            {
                //Using regual expressions to replace what is in the < > braces with an empty tring and then
                //Check if the whole line is an empty string and if it is it just does not add it
                text = Regex.Replace(text, @"<[^>]*>", string.Empty);
                if (!String.IsNullOrWhiteSpace(text))
                {
                    output.Append(text + " \r\n");
                }
               
                text = reader.ReadLine();
            }
        }
        //Writing in the same file
        using (StreamWriter sameFileOutput = new StreamWriter(@"../../output.txt"))
        {
            sameFileOutput.WriteLine(output);
        }
        Console.WriteLine("Done!");
    }
}