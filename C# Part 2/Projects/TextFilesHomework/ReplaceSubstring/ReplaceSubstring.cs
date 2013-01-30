using System;
using System.IO;

class ReplaceSubstring
{
    static void Main()
    {
        //Reading the text from the file
        using (StreamReader text = new StreamReader(@"../../text.txt"))
        {
            //Writing  in another file
            using (StreamWriter output = new StreamWriter(@"../../output.txt"))
            {
                
                string line = text.ReadLine();
                //Reading until the end of the file and for each line if we find start we just replace it it finish and write it 
                while (line != null)
                {
                    output.WriteLine(line.Replace("start", "finish"));
                    line = text.ReadLine();
                }
            }
            Console.WriteLine("Done!");
        }
    }
}