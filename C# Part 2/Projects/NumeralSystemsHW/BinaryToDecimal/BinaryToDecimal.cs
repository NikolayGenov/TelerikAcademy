using System;
using System.Collections.Generic;

class BinaryToDecimal
{
    static void Main()
    { 
        //Using list to save the result
        List<long> arr = new List<long>();

        //User input which we put in a long for longer binary numbers
        Console.WriteLine("Enter binary number");
        long binNumber = long.Parse(Console.ReadLine());
        bool isBin = true;
        while (binNumber != 0)
        {
            //Validating the number and if its valid we add it to the list
            //using bool to avoid continuing with proccessing if the input is not valid
            long temp = binNumber % 10;
            if (temp != 1 && temp != 0)
            {
                Console.WriteLine("ERROR - NOT a binary number");
                isBin = false;
                break;
            }
            //Add to the list and / by 10 to go to the next value from the long number
            arr.Add(temp);
            binNumber /= 10;
        }
        if (isBin)
        {
            //Adding all to one sum and for each possition we muplty by powers of 2
            long number = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                number += arr[i] * ((1 << i));
            }
            Console.WriteLine("The decimal number is {0}", number);
        }
    }
}