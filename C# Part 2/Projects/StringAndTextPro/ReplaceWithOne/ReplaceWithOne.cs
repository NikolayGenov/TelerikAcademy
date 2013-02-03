using System;
using System.Text;

class ReplaceWithOne
{
    static void Main(string[] args)
    { //User input
        Console.WriteLine("Enter a string");
        string input = Console.ReadLine();        
        char[] letters = input.ToCharArray();// Move the string to array of chars
        //For different cases
        switch (letters.Length)
        {
            case 0:
                Console.WriteLine("Empty string");
                break;
            case 1:
                Console.WriteLine("{0}", letters[0]);
                break;
            default:
                {
                    PrintLetters(letters);
                }
                break;
        }
    }

    private static void PrintLetters(char[] letters)
    {
        //Use stringBuilder to store the output
        StringBuilder output = new StringBuilder();
            
        //If the two chars are different we append the first to the builder
        for (int i = 0; i < letters.Length - 1; i++)
        {
            if (letters[i] != letters[i + 1])
                output.Append(letters[i]);
                
            //For the last one
            if ((i == letters.Length - 2))
            {
                output.Append(letters[i + 1]);
            }
        }
        //Print the result
        Console.WriteLine(output);
    }
}