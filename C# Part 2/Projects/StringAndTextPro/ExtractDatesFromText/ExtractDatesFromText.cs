using System;
using System.Globalization;
using System.Text.RegularExpressions;

class ExtractDatesFromText
{
    static void Main()
    {
        //Setting the culture info and format
        CultureInfo culture = new CultureInfo("en-Ca");
        var format = "dd.MM.yyyy";
        CultureInfo provider = CultureInfo.InvariantCulture;
        string pattern = @"\b\d{2}.\d{2}.\d{4}\b"; //Creating a pattern to match - it should have 2 values . 2 values . 4 values
        string input = "Well that is a date 01.01.2013 and this is another one 10.10.2010 ";
        try
        {
            //try to validate it for reach date that it finds 
            foreach (var date in Regex.Matches(input, pattern))
            {
                //If its valid it prints it out
                DateTime someDate = DateTime.ParseExact(date.ToString(), format, provider);
                Console.WriteLine(someDate.ToString(culture));
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("That is not in the correct format.");
        }
    }
}