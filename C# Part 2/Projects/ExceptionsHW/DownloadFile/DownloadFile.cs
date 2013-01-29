using System;
using System.Net;

class DownloadFile
{
    static void Main(string[] args)
    {
        try
        {
            //Using webClient to download the time and write it in the folder as the Csharp file 
            WebClient webClient = new WebClient();
            webClient.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", @"../../Logo-BASD.jpg");
            Console.WriteLine("Done!");
        }
        //Catch different exceptions - those from the web and local for user permisions
        catch (WebException)
        {
            Console.WriteLine("Invalid address!");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You do not have permisions to do that!");
        }
    }
}
