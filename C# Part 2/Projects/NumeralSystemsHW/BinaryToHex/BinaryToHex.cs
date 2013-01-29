using System;
using System.Collections.Generic;

class BinaryToHex
{
    static void Main()
    {
        //Taing input and validate it- and save it in string
        string parsedNumber = null;
        Console.WriteLine("Enter binary number: ");
        long binNumber = long.Parse(Console.ReadLine());
        bool isBin = true;
        while (binNumber != 0)
        {
            long temp = binNumber % 10;
            if (temp != 1 && temp != 0)
            {
                Console.WriteLine("ERROR - NOT a binary number");
                isBin = false;
                break;
            }
            parsedNumber += temp;
            binNumber /= 10;
        }
        if (isBin)
        {
            //reverse the string to be the desired order and then "fix" the string
            //We just add more zeros in the front if the string is missing to a %4  to be equal to 0
            parsedNumber = Reverse(parsedNumber);
            string clearBin = FixBinary(parsedNumber);
         
            //Making a list to save the result
            List<char> result = new List<char>();

           //Looping every 4 digits and then for them make a temp sum where each iteration in another loop for only 4 iterations
            for (int i = 0; i < clearBin.Length; i += 4)
            {
                int tempSum = 0;
                for (int k = 0; k < 4; k++)
                {
                    //Convert the char to string and add it to the power of 2 which we want
                    string tempDigit = (clearBin[i + k]).ToString();
                    tempSum += int.Parse(tempDigit) * (1 << (4 - k - 1));
                }
                //Take some conditions for the tempsum and covert it to char which we add to the list
                if (tempSum > 9)
                {
                    result.Add((char)('A' + tempSum - 10));
                }
                else
                {
                    result.Add((char)('0' + tempSum));
                }
            }
            //Print the result
            Console.WriteLine("The hexadecimal of this number is : ");
            foreach (char item in result)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }

    private static string FixBinary(string parsedNumber)
    {
        //If the string is "good" we just return it
        if (parsedNumber.Length % 4 == 0)
        {
            return parsedNumber;
        }
        else
        {
            //If not we jsut add zeros to the beggining
            int temp = parsedNumber.Length % 4;
            string fixedNumber = new string('0', (4 - temp));
            fixedNumber += parsedNumber;
            return fixedNumber;
        }
    }

    public static string Reverse(string s)
    {
        //Simple reverse string method
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}