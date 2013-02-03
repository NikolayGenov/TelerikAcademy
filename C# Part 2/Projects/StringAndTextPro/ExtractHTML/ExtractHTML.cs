using System;
using System.Text.RegularExpressions;

class ExtractHTML
{
    static void Main(string[] args)
    {
        //Input string
        string input = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">TelerikAcademy </a>aims to provide free real-world practicaltraining for young people who want to turn into skillful .NET software engineers.</p></body></html>";
        string pattern = "<title>(.*?)</title>";
        //Create the patern to find the tittle
        Regex regex = new Regex("<title>(.*)</title>");      
        //Extract the title and then delete it from input
        string title = regex.Match(input).Groups[1].ToString();
        input = Regex.Replace(input, pattern, string.Empty);
        //Print the name of the title
        Console.WriteLine("The Title of this HTML site is: '{0}'", title);
        Console.WriteLine();      
        //Print everything else except the tags 
        input = Regex.Replace(input, @"<[^>]*>", string.Empty);
        Console.WriteLine(input);
    }
}