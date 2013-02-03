using System;
using System.Text.RegularExpressions;

class ReplaceURLs
{
    static void Main()
    {
        //Input
        string input = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
        //Making patern to go with replacing all the url
        string paternFrom = "<a href=\"(?<url>.*?)\">(?<text>.*?)</a>";
        //The patern which we want to replace it with
        string paternTo = "[URL=${url}]${text}[/URL]";       
        //Do the replacement and then print the result
        input = Regex.Replace(input, paternFrom, paternTo);
        Console.WriteLine(input);
    }
}