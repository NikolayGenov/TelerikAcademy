using System;
using System.Globalization;

class CalculateDates
{
    static void Main()
    {
        //Create the two dates and the format
        DateTime first = new DateTime();
        DateTime second = new DateTime();
        CultureInfo provider = CultureInfo.InvariantCulture;
        var format = "dd.MM.yyyy";
        try
        {
            //Try exact parse with that format and if the user get it wrong it throws an exception whihc is handled
            Console.WriteLine("Enter a date - dd.mm.yyyy");
            first = DateTime.ParseExact(Console.ReadLine(), format, provider);
            Console.WriteLine("Enter another date - dd.mm.yyyy");
            second = DateTime.ParseExact(Console.ReadLine(), format, provider);

            int counter = 0; //For the actual number of days

            //Switches the dates if the first is after the second
            if (second.CompareTo(first) < 0)
            {
                DateTime temp = first;
                first = second;
                second = temp;
            }
            //Cound the days 
            for (DateTime date = first; second.CompareTo(date) > 0; date = date.AddDays(1.0))
            {
                counter++;
            }
            //Print the result
            Console.WriteLine("Actual Distance : {0}", counter);
        }
        catch (FormatException)
        {
            Console.WriteLine("That is not in the correct format.");
        }
    }
}