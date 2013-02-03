using System;
using System.Globalization;

class SixHoursInTheFuture
{
    static void Main()
    {
        //Create the two dates and the format
        DateTime time = new DateTime();
        //Set the culture
        CultureInfo culture = new CultureInfo("bg-BG");
        CultureInfo provider = CultureInfo.GetCultureInfo("bg-BG");
        var format = "dd.MM.yyyy hh:mm:ss";
        try
        {
            //User entes the date as asked to
            Console.WriteLine("Enter a date - dd.MM.yyyy hh:mm:ss -  day.month.year hours:minutes:seconds");
            time = DateTime.ParseExact(Console.ReadLine(), format, provider);
            //Addint the desired time
            time = time.AddHours(6.0);
            time = time.AddMinutes(30.0);
            //Geting the day of the week and the exact format to string
            string dayOfWeek = time.ToString("dddd", culture);
            string output = time.ToString(format, provider);
            //Print the new time
            Console.WriteLine("New Time: {0} {1}", output, dayOfWeek);
        }
        catch (FormatException)
        { //If the format is not valid
            Console.WriteLine("That is not in the correct format.");
        }
    }
}