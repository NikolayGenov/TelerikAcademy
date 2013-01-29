using System;

class PrintDayOfTheWeek
{
    static void Main()
    {
       
        //Using DateTime we get the time for today and then printing it using DayOfWeek to get the current day of the week
        DateTime today = DateTime.Now;
        Console.WriteLine("Today is : {0}",today.DayOfWeek);
    }
}