using System;

class PrintDifferentLetters
{
    static void Main()
    {
        //User input
        Console.WriteLine("Enter a string");
        string input = Console.ReadLine();
        //Removing all the spaces
        input = input.Replace(" ", "");
        char[] letters = input.ToCharArray();// Move the string to array of chars
        Array.Sort(letters); //Sort it 
        //For different cases
        switch (letters.Length)
        {
            case 0:
                Console.WriteLine("Empty string");
                break;
            case 1:
                Console.WriteLine("{0}: {1} times", letters[0], 1);
                break;
            default:
                {
                    CountAndPrintLetters(letters);
                }
                break;
        }
    }
  
    private static void CountAndPrintLetters(char[] letters)
    {
        int counter = 1;
        //For each letter we count how many times it is found and then print it
        for (int i = 0; i < letters.Length - 1; i++)
        {
            if (letters[i] == letters[i + 1])
                counter++;
            else
            {
                Console.WriteLine("{0}: {1} times", letters[i], counter);
                counter = 1;
            }
            //For the last one
            if (i == letters.Length - 2)
            {
                Console.WriteLine("{0}: {1} times", letters[i + 1], counter);
            }
        }
    }
}