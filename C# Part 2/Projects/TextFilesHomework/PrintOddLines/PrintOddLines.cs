using System;
using System.IO;
using System.Text;

class PrintOddLines
{
    static void Main()
    {
        //Using stringBuilder to store the output
        StringBuilder output = new StringBuilder();
        //We use the using constuction for reading files
        using (StreamReader reader = new StreamReader(@"../../text.txt"))
        {
            //Make 2 vars for each line of text and counter for the number of lines
            string text;
            int numLine = 0;          
            do
            {
                //Read until the end of the file with do while
                text = reader.ReadLine();
                //For the odd lines we append them to the StringBuilder and add a new line
                if (numLine % 2 != 0)                    
                {
                    output.Append(text+"\n");
                }
                //Inc the counter with 1 for the number of lines
                numLine++;
            }
            while (text != null);
        }
        //Print the result
        Console.WriteLine("The odd lines are");
        Console.WriteLine(output);
    }
}