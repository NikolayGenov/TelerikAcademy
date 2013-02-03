using System;

class UpcaseTag
{
    static void Main()
    { //Some input to test the program
        string input = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        //The tags and their open and starting positions
        string openTag = "<upcase>";
        string closeTag = "</upcase>";
        int posOpenTag = -1;
        int posCloseTag = -1;
        string output = null, temp = null ;
        //Loop until there are more open tags like openTag
        while (input.IndexOf(openTag, posOpenTag + 1) != -1) 
        {
            //Take the two positions
            posOpenTag = input.IndexOf(openTag, posOpenTag + 1);
            posCloseTag = input.IndexOf(closeTag, posCloseTag + 1);
            
            //Modify the positions with the length of the tags and make the output to uppercase
            temp = input.Substring((posOpenTag - openTag.Length + openTag.Length), posCloseTag - posOpenTag + closeTag.Length);
            output = input.Substring((posOpenTag + openTag.Length), posCloseTag - posOpenTag - openTag.Length).ToUpper();
            //We just replace them
            input = input.Replace(temp, output);
        }
        //The new output
        Console.WriteLine("New text: {0}", input);
    }
}