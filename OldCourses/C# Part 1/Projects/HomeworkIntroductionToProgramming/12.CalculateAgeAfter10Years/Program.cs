using System;
class CalculateAgeAfter10Years
{
    static void Main()
    {
        
        Console.WriteLine("Enter your age :");
        int curAge = int.Parse(Console.ReadLine());
        int ageAfter10Years = curAge + 10;
        Console.WriteLine("Now You are {0} years old and after 10 years You will be {1} years old",curAge,ageAfter10Years);
        
    }
}

