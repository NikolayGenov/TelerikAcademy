using System;

class IsLeapYear
{
    static void Main()
    {
        //User input then parsing the year and using DateTime to check with true or false if its leap or not 
        Console.WriteLine("Enter a year: ");
        int year = int.Parse(Console.ReadLine());       
        Console.WriteLine( "That year is leap ? : {0}", DateTime.IsLeapYear(year));
    }
}