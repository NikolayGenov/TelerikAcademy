using System;

class WorkDays
{
    static void Main()
    {
        //Array were we declare some holidays one by one
        DateTime[] holidays = { new DateTime(2013, 2, 14), new DateTime(2013, 2, 21) };
        DateTime today = DateTime.Now; // Today
        DateTime futureDate = new DateTime(2013, 2, 24); //So future day
        int workDays = 0; //Counter for the days

        //We loop from today using the DateTime (as if its an int) but we add a day with AddDays  and compare it with the ComapreTo and that returns true or false
        for (DateTime date = today; futureDate.CompareTo(date) > 0; date = date.AddDays(1.0))
        {
            //If the days are not weekends we add them to the counter
            if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
            {
                workDays++;
            }
            //Each time we check if that day is a day from one of the holidays we declared and if it is we dec the counter with 1
            foreach (DateTime holiday in holidays)
            {
                if (holiday.Date == date.Date)
                {
                    workDays--;
                }
            }
        }
        //Print out the result as only date not time and the counter
        Console.WriteLine("There are {0} work days between today ({1})(including today) and {2}", workDays, today.ToShortDateString(), futureDate.ToShortDateString());
    }
}