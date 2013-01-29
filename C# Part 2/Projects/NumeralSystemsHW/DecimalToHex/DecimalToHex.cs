using System;
using System.Collections.Generic;

class DecimalToHex
{
    static void Main()
    {
        //User input and print the method result
        Console.WriteLine("Enter decimal number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The number in hexadecimal : {0}",ToHex(number));
    }
  
    private static string ToHex(int number)
    {
        //Using list to store the data 
       List<char> arr = new List<char> ();
        //Loop until the end - number=0
        while (number !=0)
        {
            //Using chars to add to the list
            int temp = number % 16;
            if (temp > 9)
            {
                arr.Add((char)('A' + temp - 10));

            }
            else
            {
                arr.Add((char)('0' + temp));
            }
            number /= 16;
        }
        //Putting them in the backwards order
        string result=null;
        for (int i = arr.Count - 1; i >= 0; i--)
        {
            result += arr[i];
        }
        //Return the number as a string
        return result;
    }
}

