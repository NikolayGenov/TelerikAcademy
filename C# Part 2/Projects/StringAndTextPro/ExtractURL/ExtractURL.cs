using System;

class ExtractURL
{
    static void Main()
    {
        //Input as a string
        string input = "http://www.devbg.org/forum/index.php";
        int twoSlashes = input.IndexOf("//"); //Taking the index of the two slashes in after the protocol
        int singleSlash = input.IndexOf("/", twoSlashes + 2); //and then the slash after them
        string protocol = input.Substring(0, twoSlashes - 1); //Protocol is found from the start and before the index of the two slashes
        string server = input.Substring(twoSlashes + 2, singleSlash - (twoSlashes + 2)); //the server is after the two slashes 2 from there and it's length can be calculated by this simple formula
        string resource = input.Substring(singleSlash); //Everything after that is resources
        //Print the all the strings
        Console.WriteLine("URL = {0}", input);
        Console.WriteLine("[Protocol] = {0}", protocol);
        Console.WriteLine("[Server] = {0}", server);
        Console.WriteLine("[Resource] = {0}", resource);
    }
}