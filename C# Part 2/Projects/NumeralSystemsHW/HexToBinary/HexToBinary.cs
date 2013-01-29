using System;
using System.Collections.Generic;

class HexToBinary
{
    static void Main()
    {
        //User input - Must be correct to be working fine - example - A8D , 8532 , FF
        Console.WriteLine("Enter correct Hexadecimal number (With Uppercase A-F)");
        string hexNumber = Console.ReadLine();
        Console.WriteLine("The number in binary : {0}", ToBinary(hexNumber));
    }
  
    private static string ToBinary(string hexNumber)
    {
        //Using list to store the output as a string
        List<string> arr = new List<string>();        
        for (int i = 0; i < hexNumber.Length; i++)
        {
            //Take the string as chars and for each case covert that char to a 4 digit string by zeros and ones
            char temp = hexNumber[i];
            if (temp >= 'A')
            {
                arr.Add(ToBinString((temp - 'A') + 10));
            }
            else
            {
                arr.Add(ToBinString(temp - '0'));
            }
        }
        //Append the result to a string and return it
        string result = null;
        for (int i = 0; i < hexNumber.Length; i++)
        {
            result += arr[i];
        }        
        return result;
    }
  
    private static string ToBinString(int temp)
    {
        //Using that every hex number can be represented as 4 digits of zeros and ones take each number and divide it to a array of ints and then append it to a string
        int[]arr = new int[4];
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            arr[i] = temp % 2;
            temp /= 2;
        }
        string result = null;
        for (int i = 0; i < arr.Length; i++)
        {
            result += arr[i];
        }       
        return result;
    }
}