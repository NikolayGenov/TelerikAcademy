using System;
using System.IO;
using System.Text;

class DeleteOddLines
{
    static void Main()
    {
        //Using stringBuilder to store the output
        StringBuilder output = new StringBuilder();
        //We use the using constuction for reading files
        using (StreamReader reader = new StreamReader(@"../../text.txt"))
        {
            //Make 2 vars for each line of text and counter for the number of lines
            string text = reader.ReadLine();
            int numLine = 0;          
            while (text != null)
            {
                //Read until the end of the file with do while
                //For the even lines we append them to the StringBuilder and add a new line - so the odd lines are not added - aka deleted
                if (numLine % 2 == 0)                    
                {
                    output.Append(text + "\r\n");
                }
                //Inc the counter with 1 for the number of lines
                numLine++;
                text = reader.ReadLine();
            }
        }
        //Write the result in the same file
        using (StreamWriter sameFileOutput = new StreamWriter(@"../../text.txt"))
        {
            sameFileOutput.WriteLine(output);
        }
        Console.WriteLine("Done!");
        
    }
}