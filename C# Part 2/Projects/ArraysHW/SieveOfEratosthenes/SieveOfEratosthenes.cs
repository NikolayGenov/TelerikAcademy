using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SieveOfEratosthenes
{
    static void Main()
    {
        Console.WriteLine("May take some time to process and then print them");
        //We set the length and can change it later if we want to test for something different 
        
        //The interval 
        int length = 10000000;
        //The def values are false
        bool[] numbers = new bool[length];
        int endPoint = (int)Math.Sqrt(length); //Calcuating the poing to save some time looping
        for (int i = 2; i < endPoint; i++)
        {
            //For the first prime numbers we get we apply the rule to set all the numbers +i to be equal to true
            if (numbers[i] == false) 
            {
                for (int j = 2 * i; j < length; j += i)
                {
                    numbers[j] = true;
                }

            }
        }
        //Using StringBuilder to save the text and print it faster
        StringBuilder text = new StringBuilder();
        int counter = 0;//For the count of the numbers
        for (int i = 2; i < length; i++)
        { //adding to the result only the prime numbers which remained true
            if (numbers[i] == false)
            {
                counter++;
                text.Append(i);
                text.Append(" ");
            }
        }
        //Print the text and it may take some time 
        Console.WriteLine(text);
        //Just for the count we print the exact count of all the numbers in the interval
        Console.WriteLine("There are {0} prime numbers in the interval [1...{1}]", counter, length);
    }
}

