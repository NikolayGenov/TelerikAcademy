using System;

class HexToDecimal
{
    static void Main()
    {
        //User input - Must be correct to be working fine - example - A8D , 8532 , FF
        Console.WriteLine("Enter correct Hexadecimal number (With Uppercase A-F)");
        string hexNumber = Console.ReadLine();
        Console.WriteLine("The number in decimal : {0}",ToDecimal(hexNumber));
    }
  
    private static int ToDecimal(string hexNumber)
    {
        //Get the length of the string
        int number = 0;
        int length =hexNumber.Length;
        for (int i = 0; i < length; i++)
        {
            //Use get the char on that possition 
            //If its A -F its converts it to 10-15 and multiply it by 16 on the power of the possition index using bitwise
            //Else it takes the number 0-9 and do the same with the multiplication
            char temp = hexNumber[i];
            if (temp >= 'A')
            {
                number += ((temp -'A')+10) * (1 << (4*(length-i-1)));
            }
            else
            {
                number += (temp - '0') * (1 << (4 * (length - i-1)));
            }
        }
        //return an int number
        return number;
    }
}

