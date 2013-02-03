using System;
using System.Text.RegularExpressions;

class GetEmail
{
    static void Main(string[] args)
    {
        //Using email pattern 
        string pattern = @"(\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,6})";  
        //input
        string input = "This is simple email:  svetlin@nakov.com and this is another one, admin@nikolay.it";
        //Looping for all the matches we have found in the string using the patter and print them out on the console
        foreach (var item in Regex.Matches(input, pattern))
        {
            Console.WriteLine("Email : {0}", item);
        }
    }
}