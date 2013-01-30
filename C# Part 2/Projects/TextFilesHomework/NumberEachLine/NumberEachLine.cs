using System;
using System.IO;
using System.Text;

class NumberEachLine
{
    static void Main()
    { 
        //Saving the each new line of the edited text in a StrungBuilder
        StringBuilder output = new StringBuilder();
        //We use the using constuction for reading files
        using (StreamReader reader = new StreamReader(@"../../text.txt"))
        {
            int numberOfLine = 1;
            string text = reader.ReadLine();
            //Reading lines until the end of the file
            while (text != null)                
            { 
                //For each we add a number a new line, inc the counter and read again
                text = string.Format("{0}: {1}\r\n", numberOfLine, text);               
                output.Append(text);                 
                numberOfLine++;
                text = reader.ReadLine();
            }
        }
        
        using (StreamWriter outputFile = new StreamWriter(@"../../output.txt")) 
        { 
            //Write them by creating a new file in the same dir and write them in the file
            outputFile.WriteLine(output);
        }
        Console.WriteLine("Done!");
    }
}