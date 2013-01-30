using System;
using System.IO;
using System.Text;

class ConcTwoFiles
{
    static void Main()
    {
        //Using StringBuilder to hold the text from the two files
        StringBuilder text = new StringBuilder();

        using (StreamReader file1 = new StreamReader(@"../../file1.txt"))
        {
            //Read the whole first file and append it then put a new line with \r\n - (this is not a console so we use \r)
            text.Append(file1.ReadToEnd());
            text.Append("\r\n");
        }
        using (StreamReader file2 = new StreamReader(@"../../file2.txt"))
        {
            //Append the second file to the end of the first
            text.Append(file2.ReadToEnd());
        }
        using (StreamWriter fileWrite = new StreamWriter(@"../../fileOutput.txt"))
        {
            //Write them by creating a new file in the same dir and write them in the file
            fileWrite.WriteLine(text);
        }
        Console.WriteLine("Done!");
    }
}