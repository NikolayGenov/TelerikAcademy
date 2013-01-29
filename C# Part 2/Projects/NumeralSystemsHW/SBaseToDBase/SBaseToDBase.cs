using System;

class SBaseToDBase
{
    static int S, D;

    static void Main()
    {
        //User input for the bases of the systems and the number  THE ENTERED NUMBER MUST BE CORRECT FOR THAT BASE YOU HAVE ENTERNED
        Console.WriteLine("Enter S (base) (from): ");
        S = int.Parse(Console.ReadLine());
               
        Console.WriteLine("Enter a number ({0} based num system) : ", S);
        string number = Console.ReadLine();

        Console.WriteLine("Enter D (base) (to): ");
        D = int.Parse(Console.ReadLine());

        //Where we create array of ints from a string
        int[] arrayOfNumbers = GetArrayNumbers(number);
        //Print the output
        Console.WriteLine("Convered number from {0} based to {1} based system --> {2}", S, D, CovertNumber(arrayOfNumbers));
    }
  
    private static string CovertNumber(int[] arrayOfNumbers)
    {
        //First make to to decimal and then to the desired system
        long number = ToDecimal(arrayOfNumbers);
        string result = ToDBase(number);
        return result;
    }

    private static string ToDBase(long number)
    {
        //Append to a string the remainder of what we divide with D as base
        string result = null;
        while (number != 0)
        {
            //Using chars to add to the list
            long temp = number % D;
            if (temp > 9)
            {
                result += ((char)('A' + temp - 10));
            }
            else
            {
                result += ((char)('0' + temp));
            }
            number /= D;
        }
        //Then reverse the the string in the desired order
        result = Reverse(result);
        return result;
    }

    private static long ToDecimal(int[] arrayOfNumbers)
    {
        //We multiply the possition with the S on power the possition
        long result = 0;
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            result += arrayOfNumbers[arrayOfNumbers.Length - 1 - i] * (long)Math.Pow(S, i);
        }
        //then return the result as a number
        return result;
    }

    public static string Reverse(string s)
    {
        //Simple reverse string method
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
  
    private static int[] GetArrayNumbers(string number)
    {
        //If there are numbers from 11 base to 16 based systems we conver them to numbers and save everything to array of ints
        int[] numbers = new int[number.Length];
        for (int i = 0; i < number.Length; i++)
        {
            char temp = number[i];
            if (temp >= 'A')
            {
                numbers[i] = (temp - 'A') + 10;
            }
            else
            {
                numbers[i] = (temp - '0');
            }
        }
        //return the array to use it for the decimal 
        return numbers;
    }
}