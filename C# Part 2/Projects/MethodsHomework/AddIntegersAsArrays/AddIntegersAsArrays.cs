using System;

class AddintegersAsArrays
{
    static void Main()
    {
        //User input
        Console.WriteLine("Enter a number");
        string a = (Console.ReadLine());
        Console.WriteLine("Enter another number");
        string b = (Console.ReadLine());
        //Converting the string input into array of ints
        int[] arrayA = ConverNumberToArray(a);        
        int[] arrayB = ConverNumberToArray(b);
        //Method that sums the two arrays and print the result
        SumArrays(arrayA, arrayB);
    }
  
    private static void SumArrays(int[] arrayA, int[] arrayB)
    {
        //Take the length of the arrays and give the len var the max of the two arrays
        int len = Math.Max(arrayA.Length, arrayB.Length);
        //If its more than 10000 it limits it
        if (len > 10000)
        {
            len = 10000;
        }
        //Create the array were we will store the values
        int[] sumArrays = new int[len + 1];
        //Add the first array to the sum
        for (int i = 0; i < arrayA.Length; i++)
        {
            sumArrays[i] = arrayA[i];
        }
        //Add the second array to the sum
        for (int i = 0; i < arrayB.Length; i++)
        {
            sumArrays[i] += arrayB[i];
        }
        //Check for numbers larget than 10 at 1 possion and if it finds one it gives 1 to the next possition and take the %10 part
        for (int i = 0; i < len; i++)
        {
            if (sumArrays[i] > 9)
            {
                sumArrays[i + 1]++;
                sumArrays[i] %= 10;
            }
        }
        //Print the result
        PrintResult(sumArrays);
    }
  
    private static void PrintResult(int[] sumArrays)
    {
        //We make a check if the addition zero in the begining is empty and if it is we dont print it
        Console.WriteLine("The result is : ");
        if (sumArrays[sumArrays.Length - 1] != 0)
        {
            Console.Write(sumArrays[sumArrays.Length - 1]);
        }
        //Go into the array and print result
        for (int i = sumArrays.Length - 2; i >= 0; i--)
        {
            Console.Write(sumArrays[i]);
        }
        Console.WriteLine();
    }

    private static int[] ConverNumberToArray(string number)
    {
        //Make the array we we would store the values
        int[] arr = new int[number.Length];
        int temp;
        bool isInt = true;
        //Make vars for if that string is a number and the length of the string
        int len = number.Length;
        //Loop into the string and for each char it tries to parse it to int and if it can it add it to the array
        //And if the char is not an int it returns empty array and a msg
        for (int i = 0; i < len; i++)
        {
            string a = number[i].ToString();
            isInt = int.TryParse(a, out temp);
            if (isInt)
            {
                arr[len - i - 1] = temp;
            }
            else
            {
                Console.WriteLine("IT'S NOT A NUMBER!");
                return new int[0];
            }
        }
          
        return arr;
    }
}